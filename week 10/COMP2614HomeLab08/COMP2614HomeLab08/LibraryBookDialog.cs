using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BizLogic;

namespace COMP2614HomeLab08
{
    public partial class LibraryBookDialog : Form
    {
        public enum EditMode
		{
			View,
			Edit
		}

		private LibraryBook libraryBook;
		private EditMode mode;

        public LibraryBookDialog()
        {
            InitializeComponent();
        }

        public LibraryBook LibraryBook
        {
            get { return libraryBook; }
            set
            {
                libraryBook = value;
                objectToControls();
            }
        }

        public EditMode Mode
        {
            get { return mode; }
            set
            {
                this.mode = value;
                textBoxTitle.ReadOnly = textBoxAuthor.ReadOnly = textBoxCopyrightYear.ReadOnly = mode == EditMode.View;
            }
        }

        private void objectToControls()
        {
            if (libraryBook == null)
            {
                textBoxTitle.Text = textBoxAuthor.Text = textBoxCopyrightYear.Text = "";
            }
            else
            {
                textBoxTitle.Text = libraryBook.Title;
                textBoxAuthor.Text = libraryBook.Author;
                textBoxCopyrightYear.Text = libraryBook.CopyrightYear.ToString();
            }
        }

        private void controlsToObject()
        {
            if (libraryBook == null)
            {
                libraryBook = new LibraryBook();
            }

            libraryBook.Title = textBoxTitle.Text;
            libraryBook.Author = textBoxAuthor.Text;
            libraryBook.CopyrightYear = int.Parse(textBoxCopyrightYear.Text);
        }

        private bool validateData()
        {
            int year;
            int errorCount = 0;
           // string errorHeader = "";
           // string errorMessage = "";
           // string errorTitle = "";
           // string plural = "";

            if (textBoxTitle.Text.Length == 0)
            {
                errorProvider.SetError(textBoxTitle, "Enter a Title");

                //errorMessage += "\nEnter a title";
                errorCount++;
            }

            if (!int.TryParse(textBoxCopyrightYear.Text, out year) || year < 1)
            {
                errorProvider.SetError(textBoxCopyrightYear, "Enter year as a positive number");
                
               // errorMessage += "\nEnter year as a positive number";
                errorCount++;
            }

            if (errorCount > 0)
            {
                //plural = errorCount == 1 ? "" : "s";

                //errorHeader = string.Format("Please correct the following error{0}:\n", plural);
                //errorTitle = string.Format("Validation Error{0}", plural);

                //MessageBox.Show(errorHeader + errorMessage, errorTitle
                //              , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (textBoxTitle.Text == "")
                {
                    textBoxTitle.Select();
                    textBoxTitle.SelectAll();
                }
                else
                {
                    textBoxCopyrightYear.Select();
                    textBoxCopyrightYear.SelectAll();
                }
            }

            return errorCount == 0;
        }

        private void LibraryBookDialog_Load(object sender, EventArgs e)
        {
            objectToControls();

            if (this.mode == EditMode.Edit)
            {
                this.Text = "Library Book [Edit]";
            }
            else
            {
                this.Text = "Library Book [View]";
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                // clear all error messages
                errorProvider.SetError(textBoxTitle, string.Empty);
                errorProvider.SetError(textBoxAuthor, string.Empty);
                errorProvider.SetError(textBoxCopyrightYear, string.Empty);
                
                if (validateData())
                {
                    controlsToObject();
                    this.DialogResult = DialogResult.OK;
                }
            }

            catch (CopyrightYearOutOfRangeException cex)
            {
               // MessageBox.Show(cex.Message, "Copyright Year Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(textBoxCopyrightYear, cex.Message);

                textBoxCopyrightYear.Select();
                textBoxCopyrightYear.SelectAll();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
