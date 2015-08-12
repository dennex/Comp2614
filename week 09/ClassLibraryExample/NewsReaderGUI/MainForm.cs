using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using COMP2614.News;

namespace NewsReaderGUI
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
			txtNewsgroup.Text = DEFAULT_GROUP;
			setupListView();
		}

		private void btnGetArticles_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			downloadArticles();
			populateArticlesList();
			this.Cursor = Cursors.Default;
		}

		private void setupListView()
		{
			lvwArticles.View = View.Details;
			lvwArticles.FullRowSelect = true;

			ColumnHeader header;

			header = lvwArticles.Columns.Add("Date", "Date", 130);

			header = lvwArticles.Columns.Add("From", "From", 150);
			
			header = lvwArticles.Columns.Add("Lines", "Lines", 50);
			header.TextAlign = HorizontalAlignment.Right;

			// -2 width means fill remaining width of ListView.  (-1 width would mean
			// to make the width the same as the column header's text width).
			header = lvwArticles.Columns.Add("Subject", "Subject", -2);

			lvwArticles.LargeImageList = largeImages;
			lvwArticles.SmallImageList = smallImages;

			lvwArticles.AllowColumnReorder = true;

			lvwArticles.Sorting = SortOrder.Descending;
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
					MessageBox.Show("Could not find desired group.  That's odd");
				}
				else
				{
					group = groups[0];
					group.Articles = connection.GetArticleHeaders(group, DEFAULT_MAX_HEADERS);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Download", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			finally
			{
				connection.Disconnect();
			}
		}

		private void populateArticlesList()
		{
			lvwArticles.Items.Clear();

			if (group != null && group.Articles != null && group.Articles.Count > 0)
			{
				foreach (Article article in group.Articles)
				{
					ListViewItem item = lvwArticles.Items.Add(article.Date.ToString("yyyy-MM-dd hh:mm"));
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

		private void lvArticles_DoubleClick(object sender, EventArgs e)
		{
			if (lvwArticles.SelectedIndices.Count == 1)
			{
				// TODO: Download and display the selected article's body text.

				// Mark the selected article as downloaded.
				//
				// The Font.Bold property is read-only, so create a new Font object based on
				// the existing one.
				ListViewItem selectedItem = lvwArticles.Items[lvwArticles.SelectedIndices[0]];
				Font font = new Font(selectedItem.Font, FontStyle.Regular);
				selectedItem.Font = font;
			}
		}

		private void largeIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			lvwArticles.View = View.LargeIcon;
		}

		private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			lvwArticles.View = View.SmallIcon;
		}

		private void listToolStripMenuItem_Click(object sender, EventArgs e)
		{
			lvwArticles.View = View.List;
		}

		private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			lvwArticles.View = View.Details;
		}

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

	}
}