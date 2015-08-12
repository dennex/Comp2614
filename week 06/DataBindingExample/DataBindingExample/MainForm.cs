using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataBindingExample
{
    public partial class MainForm : Form
    {
        private List<Person> people;

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            people = new List<Person>();

            people.Add(new Person("John", "Smith", new DateTime(1968, 2, 17)));
            people.Add(new Person("Andrea", "Cornwall", new DateTime(1977, 3, 5)));
            people.Add(new Person("Walter", "DeMarco", new DateTime(1959, 7, 24)));

            listBoxPeople.DataSource = people;
            listBoxPeople.DisplayMember = "FullName";
        }


        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            Person newPerson =
                    new Person("Andrew", "Slater", new DateTime(1981, 1, 31));

            // Create a new Person object and add it to the collection.
            people.Add(newPerson);

            // Refresh the ListBox.
            // These will not work, ironically.  They only redraw the
            // control without changing its contents.

            listBoxPeople.Refresh();
            listBoxPeople.Update();

            // This will actuall crash! because the Items property cannot be
            // modified when the DataSource property is set.

            //lstPeople.Items.Add(newPerson);

            // When the ListBox is data-bound, you actually have to rebind it, 
            // like this:

            //listBoxPeople.DataSource = null;
            //listBoxPeople.DataSource = people;
            //listBoxPeople.DisplayMember = "FullName";	// Gotta redo this too.

            // Let's select the newly added person in the list.
            // (The SelectedItem property is writable!)
            listBoxPeople.SelectedItem = newPerson;

            // For simplicity, let's just allow the user to click this once.
            buttonAddPerson.Enabled = false;

        }

        private void listBoxPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPeople.SelectedIndex == -1)
            {
                return;
            }

            Person selectedPerson = listBoxPeople.SelectedItem as Person;

            if (selectedPerson != null)
            {
                labelSelectedPerson.Text = string.Format("{0}, born {1:MMM dd, yyyy}",
                    selectedPerson.FullName, selectedPerson.BirthDate);
            }
        }
    }
}
