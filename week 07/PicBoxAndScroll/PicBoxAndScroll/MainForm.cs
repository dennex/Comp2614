using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PicBoxAndScroll
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            radioButtonNormal.Checked = true;
            setupScrollBars();
        }

        private void radioButtonNormal_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rad = sender as RadioButton;
           
            switch (rad.Name)
            {
                case "radioButtonNormal":
                    pictureBoxMain.SizeMode = PictureBoxSizeMode.Normal;
                    break;

                case "radioButtonStretch":
                    pictureBoxMain.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "radioButtonAutoSize":
                    pictureBoxMain.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;

                case "radioButtonCenter":
                    pictureBoxMain.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;

                case "radioButtonZoom":
                    pictureBoxMain.SizeMode = PictureBoxSizeMode.Zoom;
                    break;

                default:
                    break;
            }
            pictureBoxMain.Invalidate(); // forces redraw
        }

        private void scrollBarVertical_Scroll(object sender, ScrollEventArgs e)
        {
            //Create a graphics object and draw a portion of the image in the PictureBox.
            Graphics g = pictureBoxMain.CreateGraphics();

            int xWidth = pictureBoxMain.Width;
            int yHeight = pictureBoxMain.Height;

            int x;
            int y;

            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                x = e.NewValue;
                y = scrollBarVertical.Value;
            }
            else //e.ScrollOrientation == ScrollOrientation.VerticalScroll
            {
                y = e.NewValue;
                x = scrollBarHorizontal.Value;
            }

            g.DrawImage(pictureBoxMain.Image,
              new Rectangle(0, 0, xWidth, yHeight),  //where to draw the image
              new Rectangle(x, y, xWidth, yHeight),  //the portion of the image to draw
              GraphicsUnit.Pixel);

            pictureBoxMain.Update();
        }

        private void setupScrollBars()
        {
            //Set the following scrollbar properties:

            // visibility
            scrollBarHorizontal.Visible = pictureBoxMain.Image.Width > pictureBoxMain.Width;
            scrollBarVertical.Visible = pictureBoxMain.Image.Height > pictureBoxMain.Height;

            //Minimum: Set to 0

            //SmallChange and LargeChange: Per UI guidelines, these must be set
            //    relative to the size of the view that the user sees, not to
            //    the total size including the unseen part.  In this example,
            //    these must be set relative to the picture box, not to the image.

            //Maximum: Calculate in steps:
            //Step 1: The maximum to scroll is the size of the unseen part.
            //Step 2: Add the size of visible scrollbars if necessary.
            //Step 3: Add an adjustment factor of ScrollBar.LargeChange.

            //Configure the horizontal scrollbar
            //---------------------------------------------
            if (this.scrollBarHorizontal.Visible)
            {
                this.scrollBarHorizontal.Minimum = 0;
                this.scrollBarHorizontal.SmallChange = this.pictureBoxMain.Width / 20;
                this.scrollBarHorizontal.LargeChange = this.pictureBoxMain.Width / 10;

                this.scrollBarHorizontal.Maximum = this.pictureBoxMain.Image.Size.Width - pictureBoxMain.ClientSize.Width;  //step 1

                if (this.scrollBarVertical.Visible) //step 2
                {
                    this.scrollBarHorizontal.Maximum += this.scrollBarVertical.Width;
                }

                this.scrollBarHorizontal.Maximum += this.scrollBarHorizontal.LargeChange; //step 3
            }

            //Configure the vertical scrollbar
            //---------------------------------------------
            if (this.scrollBarVertical.Visible)
            {
                this.scrollBarVertical.Minimum = 0;
                this.scrollBarVertical.SmallChange = this.pictureBoxMain.Height / 20;
                this.scrollBarVertical.LargeChange = this.pictureBoxMain.Height / 10;

                this.scrollBarVertical.Maximum = this.pictureBoxMain.Image.Size.Height - pictureBoxMain.ClientSize.Height; //step 1

                if (this.scrollBarHorizontal.Visible) //step 2
                {
                    this.scrollBarVertical.Maximum += this.scrollBarHorizontal.Height;
                }

                this.scrollBarVertical.Maximum += this.scrollBarVertical.LargeChange; //step 3
            }
            // force redraw
            pictureBoxMain.Invalidate();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            setupScrollBars();
        }
    }
}
