using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using COMP2614.Bank;

namespace ExceptionExample
{
    public partial class BankingForm : Form
    {
        private BankAccountCollection accounts;
        
        public BankingForm()
        {
            InitializeComponent();
        }


        private void BankingForm_Load(object sender, EventArgs e)
        {
            accounts = new BankAccountCollection();
            refreshControls();
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankAccount newAccount = new BankAccount(0m);
            accounts.Add(newAccount);

            repopulateAccountsList();
            listBoxBankAccounts.SelectedItem = newAccount;
        }


        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxBankAccounts.SelectedItem == null)
            {
                return;
            }

            BankAccount account = listBoxBankAccounts.SelectedItem as BankAccount;

            SingleValueInputForm dlg = new SingleValueInputForm();

            dlg.MustBeDecimalValue = true;
            dlg.Text = "Deposit";
            dlg.Prompt = "Enter amount";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Assumption: dialog already validated input as a Decimal value.
                decimal amount = decimal.Parse(dlg.Input);

                account.Deposit(amount);
                repopulateAccountsList();
            }

            dlg.Dispose();
        }


        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxBankAccounts.SelectedItem == null)
            {
                return;
            }

            BankAccount account = listBoxBankAccounts.SelectedItem as BankAccount;

            SingleValueInputForm dlg = new SingleValueInputForm();

            dlg.MustBeDecimalValue = true;
            dlg.Text = "Withdrawal";
            dlg.Prompt = "Enter amount";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Assumption: dialog already validated input as a Decimal value.
                decimal amount = decimal.Parse(dlg.Input);

                try
                {
                    account.Withdraw(amount);
                    repopulateAccountsList();
                }

                catch (NoSufficientFundsException ex)
                {
                    MessageBox.Show(
                            string.Format("{0}\n\nAccount Balance:\t{1:N2}\nWithdraw Amount:\t{2:N2}",
                                           ex.Message
                                         , ex.Account.Balance
                                         , ex.TransactionAmount)
                             , "No Sufficient Funds Exception"
                             , MessageBoxButtons.OK
                             , MessageBoxIcon.Exclamation);
                }


                catch (NoSufficientFundsSimpleException ex)
                {
                    MessageBox.Show(ex.Message, "No Sufficient Funds Simple Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "General Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            dlg.Dispose();
        }


        private void listBoxBankAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshControls();
        }


        private void refreshControls()
        {
            if (listBoxBankAccounts.SelectedItem != null)
            {
                BankAccount selectedAcct = listBoxBankAccounts.SelectedItem as BankAccount;
            
                displayAccount(selectedAcct);

                depositToolStripMenuItem.Enabled = true;
                withdrawToolStripMenuItem.Enabled = true;
            }
            else
            {
                displayAccount(null);

                depositToolStripMenuItem.Enabled = false;
                withdrawToolStripMenuItem.Enabled = false;
            }
        }


        private void displayAccount(BankAccount account)
        {
            if (account == null)
            {
                labelAccountBalance.Text = "";
            }
            else
            {
                labelAccountBalance.Text =  string.Format("{0, 10:N2}", account.Balance);
            }
        }

   
        private void repopulateAccountsList()
        {
            listBoxBankAccounts.DataSource = null;
            listBoxBankAccounts.DataSource = accounts;
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
