/* Name: Matthew Powers
 * Date: 6/2/17
 * Class: CSI 154
 * Assignment: Lab Assignment 6
 * Description: Loads the text files and then shows more information in a new form once an item is selected
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LabAssignment06True
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        // creates the list for the PersonEntry class
        List<PersonEntry> people = new List<PersonEntry>();

        // Loads the text items into the list box
        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            // Creates a new streamreader
            StreamReader inFile;
            // Assigns the new streamreader to open the text
            inFile = File.OpenText("namesandnumbers.txt");
            // Creates the counter
            int counter = 0;
            // start of the while loop that ends when it reaches the end of the text file
            while (inFile.EndOfStream == false)
            {
                // Creates a string that assigns each line of the text file to the new string
                string line = inFile.ReadLine();
                // Creates an array that takes the string that was previously assigned and splits it into seperate objects where there are commas
                string[] items = line.Split(',');
                // This loop takes the just assigned text in the array and gets rid of any white spaces that may have been there or created
                foreach(string item in items)
                {
                    item.Trim();
                }
                // Creates a new PersonEntry and assigns the 3 text fields (name, e-mail, and phone number) to the created object
                PersonEntry pe = new PersonEntry(items[0], items[1], items[2]);
                // The new object(s) get assigned to the list
                people.Add(pe);
                // The list box now gets the objects name at position of the counter
                lstbxPeople.Items.Add(people[counter]);
                // The counter increments to make sure that the next time this loops, it gets the next line of text rather than just one
                counter++;
            }
        }

        // When an item gets selected, it opens a new form and displays the text to the text boxes
        private void lstbxPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Creates a new form in memory
            frmListForm form2 = new frmListForm();
            // Creates a new PersonEntry and assigns the class object to the created object
            PersonEntry newPerson = lstbxPeople.SelectedItem as PersonEntry;
            // The text boxes get assigned the values from the name, email, and phone number of the selected object
            form2.txtbxName.Text = newPerson.Name;
            form2.txtbxEMail.Text = newPerson.Email;
            form2.txtbxPhoneNumber.Text = newPerson.PhoneNumber;
            // After everything is loaded, the form is shown
            form2.Show();
        }
    }
}
