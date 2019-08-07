/* Author: Matthew Powers
 * Date: 4/28/17
 * Class: CSI_154
 * Assignment: Excersice 3
 * Description: Displays, adds, removes, searches, and sorts names in a list box
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSI_154_Excercise_03
{
    public partial class frmStudentNames : Form
    {
        // Initalizes the form
        public frmStudentNames()
        {
            InitializeComponent();
        } // end of frmStudentNames

        // Creates an empty list of student names
        List<string> studentNames = new List<string>();

        // Populates the list of student names with random names
        private void frmStudentNames_Load(object sender, EventArgs e)
        {
            string[] nameOfStudent = { "John", "Michael", "Kyle", "Connor", "Morgan", "Jack", "Jill", "Josh", "Avery", "Audrey"};
            for (int i = 0; i < nameOfStudent.Length; i++)
            {
                studentNames.Add(nameOfStudent[i]);
            } // end of for
        }// end of frmStudentNames_Load

        // Loops through the list and then displays the names in a list box
        private void displayNames()
        {
            for (int i = 0; i < studentNames.Count; i++)
            {
                lstbxDisplay.Items.Add(studentNames[i]);
            } // end of for
        } // end of displayNames

        // Clears the list box and runs displayNames method
        private void btnDisplayNames_Click(object sender, EventArgs e)
        {
            lstbxDisplay.Items.Clear();
            displayNames();
        } // end of btnDisplayNames_Click

        // Adds a name to the end of the list
        private void addName()
        {
            studentNames.Add(txtbxAddName.Text);
        } // end of addname

        // Adds a name to the list at a specific index
        private void addIndexName()
        {
            studentNames.Insert(Convert.ToInt32(txtbxInsertLocation.Text),  txtbxInsertName.Text);
        } // end of addIndexName

        // Button that runs addName
        private void btnAddName_Click(object sender, EventArgs e)
        {
            addName();
        } // end of btnAddName_Click

        // Removes a name from the list
        private void removeName()
        {
            studentNames.Remove(txtbxRemoveName.Text);
        } // end of removeName

        // Button that runs removeName method
        private void btnRemoveName_Click(object sender, EventArgs e)
        {
            removeName();
        } // end of btnRemoveName_Click

        // Method that searches for the name of a student, then gives back the index of the name
        private void searchName()
        {
            lstbxDisplay.Items.Add(studentNames.IndexOf(txtbxSearchName.Text));
        } // end of searchName

        // Button that clears the list box and runs searchName method
        private void btnSearchName_Click(object sender, EventArgs e)
        {
            lstbxDisplay.Items.Clear();
            searchName();
        } // end of btnSearchName_Click

        // Method that sorts the names by ascending order and then runs displayNames
        private void sortAscending()
        {
            studentNames.Sort();
            displayNames();
        } // end of sortAscending

        // Method that sorts the names by descending order and then runs displayNames
        private void sortDescending()
        {
            studentNames.Reverse();
            displayNames();
        } // end of sortDescending

        // Button that clears the list box, then runs sortAscending
        private void btnSortAscending_Click(object sender, EventArgs e)
        {
            lstbxDisplay.Items.Clear();
            sortAscending();
        } // end of btnSortAscending_Click

        // Button that clears the list box, then runs sortDescending
        private void btnSortDescending_Click(object sender, EventArgs e)
        {
            lstbxDisplay.Items.Clear();
            sortDescending();
        } // end of btnSortDescending_Click

        // Button that runs addIndexName
        private void btnInsertName_Click(object sender, EventArgs e)
        {
            addIndexName();
        } // end of btnInsertName_Click
    } // end of class
} // end of namespace
