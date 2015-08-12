using System;
using System.Collections.Generic;
using System.Text;

namespace COMP2614.News
{
	/// <summary>
	/// Represents a newsgroup article with header information, like date and subject, and the 
	/// body text, which is the actual article.
	/// </summary>
	public class Article
	{
		private string id;
		private string from;
		private DateTime date;
		private string subject;
		private int lines;
		private string body;
		private int sequenceNum;

		/// <summary>
		/// Initializes a new instance of the Article class.
		/// </summary>
		/// <param name="id">ID found in the article's header.</param>
		/// <param name="sequenceNum">Sequence number assigned by the newsgroup to which this article is posted.</param>
		/// <param name="from">Email address of the person who posted the article.</param>
		/// <param name="date">Date that the article was posted to the newsgroup.</param>
		/// <param name="subject">Subject given for this article.</param>
		/// <param name="lines">Estimated number of lines of text found in the article's body.</param>
		public Article(string id, int sequenceNum, string from, DateTime date, string subject, int lines)
		{
			this.id = id;
			this.from = from;
			this.date = date;
			this.subject = subject;
			this.lines = lines;
			this.sequenceNum = sequenceNum;
		}

		/// <summary>
		/// Initializes a new instance of the Article class.
		/// </summary>
		/// <param name="id">ID found in the article's header.</param>
		/// <param name="sequenceNum">Sequence number assigned by the newsgroup to which this article is posted.</param>
		/// <param name="from">Email address of the person who posted the article.</param>
		/// <param name="date">Date that the article was posted to the newsgroup.</param>
		/// <param name="subject">Subject given for this article.</param>
		/// <param name="lines">Estimated number of lines of text found in the article's body.</param>
		/// <param name="body">Body text of the article.</param>
		public Article(string id, int sequenceNum, string from, DateTime date, string subject, int lines, string body)
			: this(id, sequenceNum, from, date, subject, lines)
		{
			this.body = body;
		}

		/// <summary>
		/// Gets the ID of this article (found in the article's header).
		/// </summary>
		public string ID { get { return id; } }

		/// <summary>
		/// Gets the email address of the person who posted this article (found in the article's header).
		/// </summary>
		public string From { get { return from; } }

		/// <summary>
		/// Gets the date that this article was posted to the newsgroup (found in the article's header).
		/// </summary>
		public DateTime Date { get { return date; } }

		/// <summary>
		/// Gets the subject of the article (found in the article's header).
		/// </summary>
		public string Subject { get { return subject; } }

		/// <summary>
		/// Gets the estimated number of lines of this article's body text (found in the article's header).
		/// </summary>
		public int LineCount { get { return lines; } }

		/// <summary>
		/// Gets or sets the body text of this article.
		/// </summary>
		public string Body
		{
			get { return body; }
			set { body = value; }
		}

		/// <summary>
		/// Gets the sequence number of this article that was assigned by the newsgroup to which this 
		/// article was posted.
		/// </summary>
		public int SequenceNumber { get { return sequenceNum; } }

		/// <summary>
		/// Returns a string representation of this object.  In this case, the article's subject.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return subject;
		}
	}

	/// <summary>
	/// Represents a collection of Article objects.
	/// </summary>
	public class ArticleCollection : List<Article>
	{
		/// <summary>
		/// Initializes a new instance of the ArticleCollection class.
		/// </summary>
		public ArticleCollection()
		{ }

		/// <summary>
		/// Initializes a new instance of the ArticleCollection class with an initial capacity.
		/// </summary>
		/// <param name="capacity">The initial capacity of the collection.  The collection can
		/// still grow past capacity.  Specify this value for efficiency when the approximate 
		/// maximum size of the collection is already known.</param>
		public ArticleCollection(int capacity)
			: base(capacity)
		{ }
	}
}
