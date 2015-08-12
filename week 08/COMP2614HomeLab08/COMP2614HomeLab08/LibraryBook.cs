using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP2614HomeLab08
{
	public class LibraryBook
	{
        public string Title { get; set; }
        public string Author { get; set; }
        public int CopyrightYear { get; set; }

        public LibraryBook() { }

		public LibraryBook(string title, string author, int copyrightYear)
		{
			Title = title;
			Author = author;
			CopyrightYear = copyrightYear;
		}

		public override string ToString()
		{
			return Title;
		}
	}
}
