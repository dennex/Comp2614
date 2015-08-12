using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COMP2614.News;

namespace ListViewExample
{
    public partial class MainForm : Form
    {
        private const string DEFAULT_HOST = "forums.sybase.com";
        private const string DEFAULT_GROUP = "sybase.public.sqlserver.general";
        private const int DEFAULT_MAX_HEADERS = 50;

        private Newsgroup group;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBoxNewsgroup.Text = DEFAULT_GROUP;
            setupListView();
        }

        private void buttonGetArticles_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            downloadArticles();
            populateArticlesList();
            this.Cursor = Cursors.Default;
        }

        private void setupListView()
        {
            listViewArticles.View = View.Details;
            listViewArticles.FullRowSelect = true;

            ColumnHeader header;

            header = listViewArticles.Columns.Add("Date", "Date", 130);

            header = listViewArticles.Columns.Add("From", "From", 150);

            header = listViewArticles.Columns.Add("Lines", "Lines", 50);
            header.TextAlign = HorizontalAlignment.Right;

            // -2 width means fill remaining width of ListView.  (-1 width would mean
            // to make the width the same as the column header's text width).
            header = listViewArticles.Columns.Add("Subject", "Subject", -2);

            listViewArticles.LargeImageList = largeImages;
            listViewArticles.SmallImageList = smallImages;

            listViewArticles.AllowColumnReorder = true;

            listViewArticles.Sorting = SortOrder.Descending;
        }

        private void downloadArticles()
        {
            NewsConnection connection = new NewsConnection();

            try
            {
                connection.Connect(DEFAULT_HOST);
                NewsgroupCollection groups = connection.GetNewsgroups(new string[] { DEFAULT_GROUP }, null);

                if (groups.Count != 1)
                {
                    MessageBox.Show("Could not find desired group"
                                  , "Error"
                                  , MessageBoxButtons.OK
                                  , MessageBoxIcon.Exclamation);
                }
                else
                {
                    group = groups[0];
                    group.Articles = connection.GetArticleHeaders(group, DEFAULT_MAX_HEADERS);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Download"
                              , MessageBoxButtons.OK
                              , MessageBoxIcon.Information);
            }
            finally
            {
                connection.Disconnect();
            }
        }


        private void populateArticlesList()
        {
            listViewArticles.Items.Clear();

            if (group != null && group.Articles != null && group.Articles.Count > 0)
            {
                foreach (Article article in group.Articles)
                {
                    ListViewItem item = listViewArticles.Items.Add(article.Date.ToString("yyyy-MM-dd hh:mm"));
                    item.SubItems.Add(article.From);
                    item.SubItems.Add(article.LineCount.ToString());
                    item.SubItems.Add(article.Subject);

                    // Now it's easy to get the Article object associated with this ListView item.
                    item.Tag = article;

                    item.ImageIndex = 0;

                    // Mark this item as not having a downloaded body text yet.
                    //
                    // The Font.Bold property is read-only, so create a new Font object based on
                    // the existing one.
                    Font font = new Font(item.Font, FontStyle.Bold);
                    item.Font = font;
                }
            }
        }

        private void listViewArticles_DoubleClick(object sender, EventArgs e)
        {
            if (listViewArticles.SelectedIndices.Count == 1)
            {
                // TODO: Download and display the selected article's body text.

                // Mark the selected article as downloaded.
                //
                // The Font.Bold property is read-only, so create a new Font object based on
                // the existing one.
                ListViewItem selectedItem = listViewArticles.Items[listViewArticles.SelectedIndices[0]];
                Font font = new Font(selectedItem.Font, FontStyle.Regular);
                selectedItem.Font = font;
            }
        }

        private void largeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewArticles.View = View.LargeIcon;
        }

        private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewArticles.View = View.SmallIcon;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewArticles.View = View.List;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewArticles.View = View.Details;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
