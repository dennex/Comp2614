using System;
using System.Collections.Generic;
using System.Text;

namespace COMP2614.News
{
	/// <summary>
	/// Represents a newsgroup, including its name and a collection of articles.
	/// </summary>
	public class Newsgroup
	{
		private string name;
		private ArticleCollection articles;
		private bool postingAllowed;
		private int firstArticleNum;
		private int lastArticleNum;

		/// <summary>
		/// Initializes a new instance of the Newsgroup class.
		/// </summary>
		/// <param name="name">Name of the newsgroup.</param>
		/// <param name="postingAllowed">Whether or not posting is allowed to this newsgroup.  This value
		/// indicates.  Note that posting may still be prohibited to a client even though this value is true.
		/// This flag exists for each newsgroup because some newsgroups are moderated or are digests, and 
		/// therefore cannot be posted to; that is, articles posted to them must be mailed to a
		/// moderator who will post them for the submitter.  This is independent of the posting permission granted 
		/// to a client by the NNTP server.
		/// </param>
		/// <param name="firstArticleNum">Sequence number of the first known article in this newsgroup.</param>
		/// <param name="lastArticleNum">Sequence number of the last known article in this newsgroup.</param>
		public Newsgroup(string name, bool postingAllowed, int firstArticleNum, int lastArticleNum)
		{
			this.name = name;
			this.postingAllowed = postingAllowed;
			this.firstArticleNum = firstArticleNum;
			this.lastArticleNum = lastArticleNum;
		}

		/// <summary>
		/// Initializes a new instance of the Newsgroup class.
		/// </summary>
		/// <param name="name">Name of the newsgroup.</param>
		/// <param name="postingAllowed">Whether or not posting is allowed to this newsgroup.  This value
		/// indicates.  Note that posting may still be prohibited to a client even though this value is true.
		/// This flag exists for each newsgroup because some newsgroups are moderated or are digests, and 
		/// therefore cannot be posted to; that is, articles posted to them must be mailed to a
		/// moderator who will post them for the submitter.  This is independent of the posting permission granted 
		/// to a client by the NNTP server.
		/// </param>
		/// <param name="firstArticleNum">Sequence number of the first known article in this newsgroup.</param>
		/// <param name="lastArticleNum">Sequence number of the last known article in this newsgroup.</param>
		/// <param name="articles">A collection of articles in this newsgroup.</param>
		public Newsgroup(string name, bool postingAllowed, int firstArticleNum, int lastArticleNum, ArticleCollection articles)
			: this(name, postingAllowed, firstArticleNum, lastArticleNum)
		{
			this.articles = articles;
		}

		/// <summary>
		/// Gets the name of this newsgroup.
		/// </summary>
		public string Name { get { return name; } }

		/// <summary>
		/// Gets whether or not posting is allowed to this newsgroup.  Note that posting may still be prohibited to 
		/// a client even though this value is true.  This flag exists for each newsgroup because some newsgroups 
		/// are moderated or are digests, and therefore cannot be posted to; that is, articles posted to them 
		/// must be mailed to a moderator who will post them for the submitter.  This is independent of the 
		/// posting permission granted to a client by the NNTP server.
		/// </summary>
		public bool PostingAllowed { get { return postingAllowed; } }

		/// <summary>
		/// Number of articles, based on the first and last sequence number specified when this newsgroup 
		/// is created.  Use this value when the Articles property is null.  If Articles is not null then
		/// use Articles.Count for a more accurate count.  Note that Articles contains those articles that
		/// have been downloaded, which may be less than the total articles currently available in this
		/// newsgroup.
		/// </summary>
		public int EstimatedArticleCount { get { return lastArticleNum - firstArticleNum; } }

		/// <summary>
		/// Gets or sets a collection of articles that have been downloaded for this newsgroup.
		/// </summary>
		public ArticleCollection Articles
		{
			get { return articles; }
			set { articles = value; }
		}

		/// <summary>
		/// Returns a string representation of this object.  In this case, the article's name.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return Name;
		}
	}

	/// <summary>
	/// Represents a collection of Newsgroup objects.
	/// </summary>
	public class NewsgroupCollection : List<Newsgroup>
	{
		/// <summary>
		/// Initializes a new instance of the NewsgroupCollection class.
		/// </summary>
		public NewsgroupCollection() { }

		/// <summary>
		/// Initializes a new instance of the NewsgroupCollection class with an initial capacity.
		/// </summary>
		/// <param name="capacity">The initial capacity of the collection.  The collection can
		/// still grow past capacity.  Specify this value for efficiency when the approximate 
		/// maximum size of the collection is already known.</param>
		public NewsgroupCollection(int capacity)
			: base(capacity)
		{ }
	}
}
