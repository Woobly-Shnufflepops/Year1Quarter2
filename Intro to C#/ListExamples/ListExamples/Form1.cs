using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListExamples
{
    public partial class Form1 : Form
    {
        // Createing a list of intergers: A collection of items
        // A list is like a dynamic array, you can add, insert, remove, and clear the list after it is created
        private List<int> numbers = new List<int>();
        // list of string type to store names setting it initially to 10 slots
        private List<string> names = new List<string>(10);

        // Creating a list and populating it with implicit values


        private List<double> grades = new List<double>() {89.0, 61.5, 67.4, 99.1};

        private int[] intArray = new int[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintList(numbers);
            // insert a value at index 5
            numbers.Insert(5, 33);
            richTextBox1.AppendText("After inserting a value \n");
            PrintList(numbers);

            // Removing by value
            if (numbers.IndexOf(43) >= 0) // Conditional removal
            {
                numbers.Remove(43);
            }
            // Removing by location (index)
            numbers.RemoveAt(3);
        }

        private void FillArray()
        {
            Random rd = new Random();

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rd.Next(11); // 0 to 10
            }
        }

        private void FillList()
        {
            // How to add a collection of values to a list in one method
            numbers.AddRange(intArray);
        }

        private void PrintList(List<int> list)
        {
            richTextBox1.Clear();
            // Print the list of grades to the text box using a foreach loop to iterate over the items in the list
            foreach (int item in numbers)
            {
                richTextBox1.AppendText(item.ToString("f1") + " ");
            }
            richTextBox1.AppendText("\n");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Run a random generator to create random numbers and add them to the list
            Random rd = new Random();
            // numbers.Clear();
            for (int i = 0; i < 20; i++)
            {
                int x = rd.Next(10, 101);
                numbers.Add(x);
            }
        }

        private void btnFillList_Click(object sender, EventArgs e)
        {
            FillArray();
            FillList();

            PrintList(numbers);

            MessageBox.Show("Array size = " + intArray.Length + " and List size = " + numbers.Count);
        }
    }
}
