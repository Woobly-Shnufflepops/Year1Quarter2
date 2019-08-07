using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatthewPowers_Employee
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private List<string> EmployeeList = new List<string>();
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            Employee Susan = new Employee("Susan Meyers", 47899, "Accounting", "Vice President");
            Employee Mark = new Employee("Mark Jones", 39119, "IT", "Programmer");
            Employee Joy = new Employee("Joy Rogers", 81774, "Manufacturing", "Engineer");
            EmployeeList.Add(Susan.ToString());
            EmployeeList.Add(Mark.ToString());
            EmployeeList.Add(Joy.ToString());
        }

        private void DisplayEmployees(List<string> List)
        {
            rchtxtbxDisplay.AppendText("Name                  ID Number                  Department            Position\n");
            foreach (string item in EmployeeList)
            {
                rchtxtbxDisplay.AppendText(item.ToString() + "\n");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DisplayEmployees(EmployeeList);
        }
    }
}
