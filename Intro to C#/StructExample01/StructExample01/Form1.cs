using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StructExample01
{
    struct StudentRecord
    {
        private string _name;
        private string _id;
        private double _grade;

        // Implicit constructor (default): Don't need to add it in C#, as C# provides you with one
        // Explicit constructor (has paramaeters). Use it to initialize ALL the fields
        public StudentRecord(string name, string id, double grade)
        {
            _name = name;
            _id = id;
            _grade = grade;
        }
        // Properties
        public string Name
        { 
        get { return _name; }
        set { _name = value; }
        }
        
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public double Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        public StudentRecord AddGrades(StudentRecord st)
        {
            StudentRecord temp = new StudentRecord();
            temp.Grade = Grade + st.Grade;
            return temp;
        }
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
            // Create a structure value/object a structure object is a value-type (no memory on the heap)
            //StudentRecord student = new StudentRecord();
            //EnterData(ref student);
            //StudentRecord student;
            //EnterData(out student);
            students.Add(EnterData2());
            //students.Add(student);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void EnterData(out StudentRecord student)
        {
            student = new StudentRecord
                (
                textBox1.Text,
                textBox2.Text,
                double.Parse(textBox3.Text)
                );
        }

        private StudentRecord EnterData2()
        {
            StudentRecord student = new StudentRecord
                (
                textBox1.Text,
                textBox2.Text,
                double.Parse(textBox3.Text)
                );
            return student;
        }

        private double AddAllGrades()
        {
            StudentRecord st = new StudentRecord();
            // double totalGrade = 0.0;

            foreach(StudentRecord student in students)
            {
                st = st.AddGrades(student);
                // totalGrade += student.Grade;
            }

            return st.Grade;
            // return totalGrade;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(StudentRecord st in students)
            {
                string str = st.Name + ", " + st.Id + ", " + st.Grade;
                listBox1.Items.Add(str);
            }

            listBox1.Items.Add(AddAllGrades().ToString());
        }
    }
}
