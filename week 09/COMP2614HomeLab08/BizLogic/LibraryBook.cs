using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BizLogic
{
    public class LibraryBook
    {
        public string Title { get; set; }
        public string Author { get; set; }

        // public int CopyrightYear { get; set; } convert to standard property method to include validation.

        private int copyrightYear;

        public int CopyrightYear
        {
            get { return copyrightYear; }
            set
            {
                if (value > DateTime.Now.Year) // test in single location
                {
                    throw new CopyrightYearOutOfRangeException(value);
                }
                else
                {
                    copyrightYear = value;
                }
            }
        }

        public LibraryBook() { }

        public LibraryBook(string title, string author, int copyrightYear)
        {
            Title = title;
            Author = author;
            CopyrightYear = copyrightYear; // assign to property to invoke validation test
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
