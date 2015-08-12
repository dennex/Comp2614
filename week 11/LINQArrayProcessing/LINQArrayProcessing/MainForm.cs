using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LINQArrayProcessing
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void buttonQuery_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[] { 6, 37, 4, 17, 8, 27 };

            string res = numbers.Count().ToString() + "\r\n";
            res += numbers.Sum().ToString() + "\r\n";
            res += numbers.Min().ToString() + "\r\n";
            res += numbers.Max().ToString() + "\r\n\r\n";

            var query = from num in numbers
                        where num % 2 == 0
                        select num;

            res += query.Count().ToString() + "\r\n";
            res += query.Sum().ToString() + "\r\n";
            res += query.Min().ToString() + "\r\n";
            res += query.Max().ToString() + "\r\n\r\n";

            textBoxResult.Text = res;
        }


        private void buttonDelayed_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[] { 6, 32, 4, 17, 8, 27 };

            string res = String.Empty;

            var query = from num in numbers
                        where num % 2 == 0
                        select num;

            foreach (var num in query)
            {
                res += num.ToString() + "\r\n";
            }

            res += "\r\n";

            numbers[0] = 52;

            foreach (var num in query)
            {
                res += num.ToString() + "\r\n";
            }

            textBoxResult.Text = res;
        }
    }
}
