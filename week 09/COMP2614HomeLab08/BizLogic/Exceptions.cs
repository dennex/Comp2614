using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BizLogic
{
    public class CopyrightYearOutOfRangeException : Exception
    {
        private int copyrightYear;

        public CopyrightYearOutOfRangeException(int copyrightYear)
            : base("Copyright year must not occur in the future")
        {
            this.copyrightYear = copyrightYear;
        }

        public int CopyrightYear { get { return copyrightYear; } }
    }
}
