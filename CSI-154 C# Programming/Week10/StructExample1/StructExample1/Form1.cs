using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StructExample1
{
    struct StudentRecord
    {
        public string name;
        public string id;
        public double grade;
    }

    public partial class Form1 : Form
    {
        List<StudentRecord> students = new List<StudentRecord>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create a structure value/object
            // a structure object is value-type (no memory in the heap)
            StudentRecord student = new StudentRecord();
            EnterData(ref student);

            students.Add(student);

        }

        private void EnterData(ref StudentRecord student)
        {
            student.name = textBox1.Text;
            student.id = textBox2.Text;
            student.grade = double.Parse(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (StudentRecord st in students)
            {
                string str = st.name + ", " + st.id + ", " + st.grade;
                listBox1.Items.Add(str);
            }
        }
    }
}
