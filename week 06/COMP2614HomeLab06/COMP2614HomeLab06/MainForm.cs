using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace COMP2614HomeLab06
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxCities.Sorted = true;
            listBoxContacts.Sorted = true;

            populateCitiesList();
            initializeControlsForTab();

            labelContact.Text = string.Empty;
        }

        private void populateCitiesList()
        {
            comboBoxCities.Items.Clear();

            comboBoxCities.Items.Add(new City("Vancouver", 545681));
            comboBoxCities.Items.Add(new City("Victoria", 335000));
            comboBoxCities.Items.Add(new City("Toronto", 4558800));
            comboBoxCities.Items.Add(new City("New York", 8085742));
            comboBoxCities.Items.Add(new City("Moose Jaw", 34236));

            labelCity.Text = string.Empty;
        }

        private void initializeControlsForTab()
        {
            // Set the default button to the one on the tab that's currently showing.
            if (tabControlMain.SelectedTab == tabPagePersonalContacts)
            {
                AcceptButton = buttonAddContact;
                textBoxContactName.Select();
                textBoxContactName.SelectAll();
            }
            else if (tabControlMain.SelectedTab == tabPageCityDemographics)
            {
                AcceptButton = buttonResetCities;
            }
        }

        private void displayContact(Contact contact)
        {
            if (contact == null)
            {
                labelContact.Text = "";
            }
            else
            {
                string contactDetails = contact.Name;

                if (contact.Phone.Length > 0)
                {
                    contactDetails += ", " + contact.Phone;
                }

                if (contact.Email.Length > 0)
                {
                    contactDetails += ", " + contact.Email;
                }

                labelContact.Text = contactDetails;
            }
        }

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            if (textBoxContactName.Text == "")
            {
                MessageBox.Show("Enter a name.", "Add Contact"
                               , MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxContactName.Select(); // sets focus to ContactName textbox
            }
            else
            {
                listBoxContacts.Items.Add(
                        new Contact(textBoxContactName.Text, textBoxContactPhone.Text, textBoxContactEmail.Text));

                // prepare for next entry - clear textboxes and set focus to name textbox

                textBoxContactName.Text = "";             // three ways to
                textBoxContactPhone.Text = string.Empty;  //   clear the contents
                textBoxContactEmail.Clear();              //   of a textbox

                textBoxContactName.Select(); // sets focus to ContactName textbox
            }
        }

        private void btnRemoveContact_Click(object sender, EventArgs e)
        {
            if (listBoxContacts.Items.Count == 0)
            {
                MessageBox.Show("List is empty.", "Remove Contact"
                               , MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }                                                                       
            else if (listBoxContacts.SelectedIndex == -1)                           
            {                                                                       
                MessageBox.Show("Select a contact to remove.", "Remove Contact"     
                               , MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                // Remove the selected item - there is more than one way to do this.
                listBoxContacts.Items.Remove(listBoxContacts.SelectedItem);
                //listBoxContacts.Items.RemoveAt(listBoxContacts.SelectedIndex);
            }
        }

        private void listBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Make sure something is selected before proceeding.
            if (listBoxContacts.SelectedIndex != -1)
            {
                // Get a reference to the Contact object that corresponds to the
                // selected list item.
                //
                // The ListBox stores all types of objects as type System.Object,
                // so it is necessary to "down" cast to Contact before using that
                // object.

                Contact contact = listBoxContacts.SelectedItem as Contact;
                displayContact(contact);
            }
            else
            {
                displayContact(null);
            }
        }

        private void comboBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCities.SelectedIndex != -1)
            {
                // Get the object associated with the selected ComboBox item.
                // Since it comes back as type object, it's necessary to 
                // downcast it to a City type.  It's always a good idea to make
                // sure an object reference actually does refer to a target type
                // before downcasting.  The 'as' operator casts and validates in one step,
                // returning null if the cast fails.  Hence, check city afterwards.

                City city = comboBoxCities.SelectedItem as City;

                if (city != null)
                {
                    labelCity.Text = string.Format("{0}, population {1:n0}", city.Name, city.Population);

                    // Remove the city from the ComboBox. 
                    // There are a number of ways to do this.

                    comboBoxCities.Items.Remove(city);
                    //comboBoxCities.Items.Remove(comboBoxCities.SelectedItem);
                    //comboBoxCities.Items.RemoveAt(comboBoxCities.SelectedIndex);
                }
            }
        }

        private void buttonResetCities_Click(object sender, EventArgs e)
        {
            populateCitiesList();
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            initializeControlsForTab();
        }     
    }
}
