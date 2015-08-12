using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using COMP2614.News;
using System.Diagnostics;

namespace DialogExample
{
	public partial class MainForm : Form
	{
		private const string DEFAULT_HOST = "forums.sybase.com";
        private const string DEFAULT_NEWSGROUP = "sybase.public.sqlserver.general";
		private const int DEFAULT_MAX_HEADERS = 100;

		private Newsgroup group;
		private NewsConnection connection;

		public MainForm()
		{
			InitializeComponent();
		}

		#region "Event Handlers"

		private void MainForm_Load(object sender, EventArgs e)
		{
			setupListView();
			refreshControls();
		}

        private void buttonGetArticles_Click(object sender, EventArgs e)
        {
            GetNewsgroupForm dlg = new GetNewsgroupForm();

            dlg.NewsgroupName = DEFAULT_NEWSGROUP;

            dlg.ShowDialog();

            if (dlg.DialogResult == DialogResult.OK)
            {
	            this.Cursor = Cursors.WaitCursor;

	            downloadArticles(dlg.NewsgroupName);
	            populateArticlesList();
        		
	            refreshControls();
	            this.Cursor = Cursors.Default;
            }

            dlg.Dispose();
        }

		private void lvArticles_DoubleClick(object sender, EventArgs e)
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
				refreshControls();
			}
		}

		private void largeIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			listViewArticles.View = View.LargeIcon;
			refreshControls();
		}

		private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			listViewArticles.View = View.SmallIcon;
			refreshControls();
		}

		private void listToolStripMenuItem_Click(object sender, EventArgs e)
		{
			listViewArticles.View = View.List;
			refreshControls();
		}

		private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			listViewArticles.View = View.Details;
			refreshControls();
		}

		private void openConnectionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ConnectionForm dlg = new ConnectionForm();
			dlg.ShowDialog();

			if (dlg.DialogResult == DialogResult.OK)
			{
				connection = dlg.Connection;
			}
			dlg.Dispose();

			refreshControls();
		}

		private void closeConnectionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			connection.Disconnect();
			refreshControls();
            listViewArticles.Items.Clear();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (connection != null && connection.ConnectionState == NewsConnection.State.Open)
			{
				if (MessageBox.Show(
						"Still connected.  Are you sure you want to exit?",
						Application.ProductName,
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question,
						MessageBoxDefaultButton.Button2) == DialogResult.No)
				{
					// Don't let the form close.
					e.Cancel = true;
				}
				else
				{
					// Do cleanup before form closes.
					connection.Disconnect();
				}
			}
		}

		#endregion

		#region "Other Methods"

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

		private void downloadArticles(string newsgroup)
		{
			NewsConnection connection = new NewsConnection();

			try
			{
				connection.Connect(DEFAULT_HOST);
				NewsgroupCollection groups = connection.GetNewsgroups(new string[] { newsgroup }, null);

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

		private void refreshControls()
		{
			bool connected = 
					(connection != null 
					&& connection.ConnectionState == NewsConnection.State.Open);

			buttonGetArticles.Enabled = connected;
			openConnectionToolStripMenuItem.Enabled = !connected;
			closeConnectionToolStripMenuItem.Enabled = connected;

			setConnectionStatus(connected);
		}

		private void setConnectionStatus(bool isConnected)
		{
			if (isConnected)
			{
				labelConnectionStatus.Text = "Connected";
			}
			else
			{
				labelConnectionStatus.Text = "Disconnected";
			}
		}

		#endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

	}
}