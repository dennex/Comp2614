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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();           
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            LibraryBookDialog dlg = new LibraryBookDialog();

            dlg.Mode = LibraryBookDialog.EditMode.Edit;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                listBoxLibraryBooks.Items.Add(dlg.LibraryBook);
            }

            dlg.Dispose();
        }

        private void listBoxLibraryBooks_DoubleClick(object sender, EventArgs e)
        {
            // It is important to make sure something in the ListBox is selected.
            // (The user could have double clicked on the ListBox control when it was empty).
            if (listBoxLibraryBooks.Items.Count == 0)
            {
                MessageBox.Show("List is empty", "Library Book Viewer"
                               , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (listBoxLibraryBooks.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to display", "Library Book Viewer"
                               , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Get a reference to the LibraryBook object the corresponds to the selected
                // ListBox item.  Use the 'as' operator to do two things: 1) attempt to cast
                // from object to LibraryBook, and 2) verify that the object is really a LibraryBook
                // ('as' returns null if the cast fails).
                LibraryBook libraryBook = listBoxLibraryBooks.SelectedItem as LibraryBook;

                // Display the selected library book.
                LibraryBookDialog dlg = new LibraryBookDialog();
                dlg.LibraryBook = libraryBook;
                dlg.Mode = LibraryBookDialog.EditMode.View;
                dlg.ShowDialog();

                dlg.Dispose();
            }
        }
    }
}
