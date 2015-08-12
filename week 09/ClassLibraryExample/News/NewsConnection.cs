using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
//using System.Diagnostics;

namespace COMP2614.News
{
    /// <summary>
    /// Represents current connection state
    /// </summary>
    public enum State
    {
        /// <summary>
        /// Connection is closed
        /// </summary>
        Closed,

        /// <summary>
        /// Connection is open
        /// </summary>
        Open
    }

	/// <summary>
	/// Represents a connection to a news server.  All download and posting activity is performed
	/// with this class.
	/// </summary>
	public class NewsConnection
	{
		private const int BUFFER_SIZE = 1024;

		private TcpClient tcpClient;
		private Buffer buffer;
		private State state;


		/// <summary>
		/// Initializes a new instance of the NewsConnection class.
		/// </summary>
		public NewsConnection()
		{
			tcpClient = new TcpClient();
			buffer = new Buffer();
		}

		/// <summary>
		/// Connects to the given news server using port 119 (default NNTP port).  Throws an 
		/// exception if the connection fails.
		/// </summary>
		/// <param name="server">name of the news server to connect to (e.g. news.microsoft.com)</param>
		public void Connect(string server)
		{
			string response;

			tcpClient.Connect(server, 119);
			response = Response();

			if (response.Substring(0, 3) != "200")
			{
				throw new NntpException(response);
			}
			else
			{
				state = State.Open;
			}
		}

		/// <summary>
		/// Disconnects from the news server.  If there is no connection, this method does nothing.
		/// </summary>
		public void Disconnect()
		{
			string message;
			string response;

			try
			{
				message = "QUIT\r\n";
				Write(message);
				response = Response();
				state = State.Closed;
			}
			catch
			{
			}
		}

		/// <summary>
		/// Downloads all newsgroups, without articles.  Use GetArticleHeaders and GetArticle methods
		/// to get article information.
		/// </summary>
		/// <returns>A collection of Newsgroup objects.  Each object's Articles property will be
		/// null.  Use GetArticleHeaders to populate these objects with Article objects.</returns>
		public NewsgroupCollection GetNewsgroups()
		{
			return GetNewsgroups(null, null);
		}

		/// <summary>
		/// If includeList is not null then this method downloads the newsgroups
		/// that have any of the words in includeList in any part of the newsgroup name.  If excludeList
		/// is not null then this method downloads the newsgroups that do not have any of the words in 
		/// the excludeList in any part of the newsgroup name.  If both parameters are null then all newsgroups
		/// are downloaded; if both are not null then an assertion is raised.
		/// </summary>
		/// <param name="includeList">A collection of strings to search for in the newsgroup names.  If any 
		/// of the words are in any part of the newsgroup name then that newsgroup is downloaded.  This value
		/// must be null if excludeList is not null.</param>
		/// <param name="excludeList">A collection of strings to search for in the newsgroup names.  If any
		/// of the words are in any part of the newsgroup name then that newsgroup is not downloaded.  This
		/// value must be null if includeList is not null.</param>
		/// <returns>A collection of Newsgroup objects that match the filter criteria given by includeList
		/// or by excludeList.  Each object's Articles property will be null.  Use GetArticleHeaders to populate 
		/// these objects with Article objects.</returns>
		public NewsgroupCollection GetNewsgroups(IList<string> includeList, IList<string> excludeList)
		{
			string message;
			string response;
			NewsgroupCollection groups = new NewsgroupCollection();


			message = "LIST\r\n";
			Write(message);
			response = Response();
			if (response.Substring(0, 3) != "215")
			{
				throw new NntpException(response);
			}

			// Suck next line of data from the socket.
			response = Response();
			while (response != ".\r\n" && response != ".\n")
			{
				// The response line should take the format:
				// group last first p
				//
				// groupName - name of the group
				// last - sequence number of the last message
				// first - sequence number of the first message
				// p - boolean value equal to y or n indicating whether or not posting is allowed
				//     (note: this is independent of whether the particular news server allows
				//     posting; some groups are moderated and therefore can only have posting by 
				//     the moderator).
				string[] values = response.Split(' ');

				// I don't think this would happen, but...
				if (values.Length != 4)
				{
					throw new NntpException("LIST command returned unexpected results.");
				}

				string groupName = values[0];
				int last = int.Parse(values[1]);
				int first = int.Parse(values[2]);
				bool postingAllowed = values[3].Trim().ToLower() == "y";

				Newsgroup newGroup;

				if (includeList != null)
				{
					// An include list has been supplied.  Add this group only if the group name
					// contains one of the include list strings.

					foreach (string includeString in includeList)
					{
						if (groupName.Contains(includeString))
						{
							newGroup = new Newsgroup(groupName, postingAllowed, first, last);
							groups.Add(newGroup);
							break;
						}
					}
				}
				else if (excludeList != null)
				{
					// An exclude list has been supplied.  Add this group only if the group name
					// contains *none* of the include list strings.

					bool contains = false;
					foreach (string excludeString in excludeList)
					{
						if (groupName.Contains(excludeString))
						{
							contains = true;
							break;
						}
					}

					if (!contains)
					{
						newGroup = new Newsgroup(groupName, postingAllowed, first, last);
						groups.Add(newGroup);
					}
				}
				else
				{
					// Neither include nor exclude list has been supplied.  Add this group.
					newGroup = new Newsgroup(groupName, postingAllowed, first, last);
					groups.Add(newGroup);
				}

				// Pump the loop.
				response = Response();
			}

			return groups;
		}

		/// <summary>
		/// Downloads all article headers for the given group.  Currently, only some of the header fields are 
		/// downloaded: id, from, date, subject, lines.  The body is not downloaded.  Use GetArticle to download
		/// an article's body text.
		/// </summary>
		/// <param name="group">Newsgroup whose article headers will be downloaded.</param>
		/// <returns>A collection of Article objects contained in the given newsgroup.  The articles' body
		/// text is not downloaded.  Use GetArticle to download an article's body text.</returns>
		public ArticleCollection GetArticleHeaders(Newsgroup group)
		{
			return GetArticleHeaders(group, -1);
		}

		/// <summary>
		/// Downloads up to maxHeaders article headers from the given group.  The latest ones are chosen.
		/// Currently, only some of the header fields are downloaded: id, from, date, subject, lines.  
		/// The body is not downloaded.  Use GetArticle to download an article's body text.
		/// </summary>
		/// <param name="group">Newsgroup whose articles headers will be downloaded.</param>
		/// <param name="maxHeaders">Maximum number of article headers to download.  The latest ones are chosen.</param>
		/// <returns>A collection of Article objects contained in the given newsgroup.  The articles' body
		/// text is not downloaded.  Use GetArticle to download an article's body text.</returns>
		public ArticleCollection GetArticleHeaders(Newsgroup group, int maxHeaders)
		{
			string message;
			string response;
			ArticleCollection articles = null;

			// Get the article numbers of the first and last articles in the group, and an 
			// estimate of the number of articles on file in the group.

			try
			{
				message = "GROUP " + group.Name + "\r\n";
				Write(message);
				response = Response();
				if (response.Substring(0, 3) != "211")
				{
					throw new NntpException(response);
				}

				char[] seps = { ' ' };
				string[] values = response.Split(seps);

				int start = Int32.Parse(values[2]);
				int end = Int32.Parse(values[3]);
				int estimatedArticleCount = end - start;
				if (estimatedArticleCount < 0) estimatedArticleCount = 100;

				// Was a maximum specified?
				if (maxHeaders != -1 && start + maxHeaders < end)
				{
					start = end - maxHeaders;
				}

				articles = new ArticleCollection(estimatedArticleCount);

				// Create a collection of Article objects, storing just the heading information
				// into them.

				DateTime date;
				string from, subject, id;
				int numLines;
				bool allFieldsObtained;

				int sequenceNum;
				for (sequenceNum = start; sequenceNum < end; ++sequenceNum)
				{
					message = "HEAD " + sequenceNum + "\r\n";
					Write(message);
					response = Response();
					if (response.Substring(0, 3) == "423")
					{
						// 423 - No such article number in this group.
						continue;
					}

					// 221 means article retrieved, head follows.
					if (response.Substring(0, 3) != "221")
					{
						throw new NntpException(response);
					}

					date = DateTime.MinValue;
					from = subject = id = "";
					numLines = -1;
					allFieldsObtained = false;

					response = Response();
					while (response != ".\r\n" && response != ".\n" && !allFieldsObtained)
					{
						// Find the delimiter--usually a colon but seems to be equals sign sometimes.
						// If neither is found then move on.
						int delimiterIdx;
						delimiterIdx = response.IndexOf(':');
						if (delimiterIdx == -1) delimiterIdx = response.IndexOf('=');
						if (delimiterIdx == -1)
						{
							response = Response();
							continue;
						}

						string headerFieldName = response.Substring(0, delimiterIdx).ToLower();
						string headerFieldValue = response.Substring(delimiterIdx + 2);

						headerFieldValue = headerFieldValue.Replace("\r\n", "");

						switch (headerFieldName)
						{
							case "message-id":
								id = headerFieldValue;
								break;
							case "from":
								from = headerFieldValue;
								break;
							case "date":
								DateTime.TryParse(headerFieldValue, out date);
								break;
							case "subject":
								subject = headerFieldValue;
								break;
							case "lines":
								int.TryParse(headerFieldValue, out numLines);
								break;
							default:
								break;
						}

						allFieldsObtained = (id != "" && from != "" && date != DateTime.MinValue && subject != "" && numLines != -1);
						if (allFieldsObtained)
						{
							// Finish getting rest of header but don't go through the switch.
							response = Response();
							while (response != ".\r\n" && response != ".\n")
							{
								response = Response();
							}
						}
						else
						{
							response = Response();
						}
					}

					Article newArticle;
					newArticle = new Article(id, sequenceNum, from, date, subject, numLines);
					articles.Add(newArticle);
				}
			}
			catch
			{
				// Ideally, I want to let this exception raise to the UI but we don't covered 
				// exception handling until later, so just swallow it for now.
			}

			return articles;
		}

		/// <summary>
		/// Downloads the body text of the given article, storing it into the Body property of article.
		/// </summary>
		/// <param name="group">Newsgroup to which article belongs.</param>
		/// <param name="article">Article for which to download body text.</param>
		/// <returns>True if successful and the body text is not empty.</returns>
		public bool GetArticle(Newsgroup group, Article article)
		{
			string message;
			string response;
			StringBuilder articleStringBuilder = new StringBuilder();

			// Gotta get the group before getting an article (the server is stateful
			// and this sets the group).
			message = "GROUP " + group.Name + "\r\n";
			Write(message);
			response = Response();
			if (response.Substring(0, 3) != "211")
			{
				throw new NntpException(response);
			}

			message = "ARTICLE " + article.SequenceNumber + "\r\n";
			Write(message);
			response = Response();
			if (response.Substring(0, 3) == "423")
			{
				// 423 - No such article number in this group.
				return false;
			}

			// 220 means Article retrieved, head and body follow
			if (response.Substring(0, 3) != "220")
			{
				throw new NntpException(response);
			}

			// Read past the head.
			response = Response();
			while (response != "\r\n" && response != "\n")
			{
				response = Response();
			}

			// Read the body.
			response = Response();
			while (response != ".\r\n" && response != ".\n")
			{
				articleStringBuilder.Append(response);
				response = Response();
			}

			article.Body = articleStringBuilder.ToString();

			return article.Body != null && article.Body.Length > 0;
		}


        private void Write(string message)
		{
			System.Text.ASCIIEncoding en = new System.Text.ASCIIEncoding();

			byte[] WriteBuffer = new byte[BUFFER_SIZE];
			WriteBuffer = en.GetBytes(message);

			NetworkStream stream = tcpClient.GetStream();
			stream.Write(WriteBuffer, 0, WriteBuffer.Length);

#if VERBOSE_DEBUG_MSGS
			Debug.WriteLine(" WRITE:" + message);
#endif
		}

		private string Response()
		{
			System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
			byte[] serverBuff = new Byte[BUFFER_SIZE];
			byte[] smallBuff = new Byte[2];	// (CS) I don't know why this has to be [2].
			string result;

			NetworkStream stream = tcpClient.GetStream();

			int count = 0;

			int bytes = stream.Read(smallBuff, 0, 1);
			while (count < BUFFER_SIZE && bytes == 1 && smallBuff[0] != '\n')
			{
				serverBuff[count++] = smallBuff[0];
				bytes = stream.Read(smallBuff, 0, 1);
			}
			if (count < BUFFER_SIZE && bytes == 1 && smallBuff[0] == '\n')
			{
				serverBuff[count++] = smallBuff[0];
			}


			if (count > 0)
			{
				result = enc.GetString(serverBuff, 0, count);
			}
			else
			{
				result = "";
			}


#if VERBOSE_DEBUG_MSGS
			Debug.WriteLine(" READ:" + retval);
#endif

			return result;
		}

		/// <summary>
		/// Gets the connection state of this object.
		/// </summary>
		public State ConnectionState { get { return state; } }
	}

    /// <summary>
    /// Custom exception class
    /// </summary>
	public class NntpException : Exception
	{
        /// <summary>
        /// Default constructor
        /// </summary>
        public NntpException() { }

        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="str">Error message</param>
		public NntpException(string str)
			: base(str)
		{ }
	}
}
