using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace ValidationDemoOF
{
    public partial class MainForm : Form
    {
        private const int MAX_TICKETS = 10;

        private int previousPurchase = 0;
        private int ticketsRemaining = MAX_TICKETS;

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            updateDisplay();
            labelResult.Text = string.Empty;
        }

        private void updateDisplay()
        {
            ticketsRemaining = MAX_TICKETS - previousPurchase;

            labelMaxTickets.Text = MAX_TICKETS.ToString("N0");
            labelTotalPurchased.Text = previousPurchase.ToString("N0");
            labelTicketsRemaining.Text = ticketsRemaining.ToString("N0");
        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            purchaseTickets();
            textBoxPurchaseQty.Select();
            textBoxPurchaseQty.SelectAll();
        }

        private void purchaseTickets()
        {
            int requested;

            if (int.TryParse(textBoxPurchaseQty.Text, NumberStyles.Any, CultureInfo.InvariantCulture.NumberFormat, out requested))
            {
                errorProvider.SetError(textBoxPurchaseQty, string.Empty);
            }
            else
            {
                errorProvider.SetError(textBoxPurchaseQty, "Enter a Whole Number");
                return;
            }

            if (requested > 0)
            {
                errorProvider.SetError(textBoxPurchaseQty, string.Empty);
            }
            else
            {
                errorProvider.SetError(textBoxPurchaseQty, "Minimum Request Quantity is 1 Ticket");
                return;
            }

            
            if (previousPurchase + requested > MAX_TICKETS) // Over allotment test
            {
                errorProvider.SetError(textBoxPurchaseQty
                    , string.Format("Maximum Tickets Allowed is {0}", MAX_TICKETS));

                labelResult.Text = string.Empty;
                return;
            }
            else
            {
                errorProvider.SetError(textBoxPurchaseQty, string.Empty);
                previousPurchase += requested;
                updateDisplay();

                string plural = requested == 1 ? "" : "s";

                labelResult.Text = string.Format("{0:N0} ticket{1} purchased"
                                              , requested, plural);
            }
        }














































        private void labelQtyPrompt_DoubleClick(object sender, EventArgs e)
        {
            textBoxPurchaseQty.Text = int.MaxValue.ToString();
        }
    }
}
