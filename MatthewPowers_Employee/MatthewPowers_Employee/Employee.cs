using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewPowers_Employee
{
    class Employee
    {
        private string _name;
        private int _idnumber;
        private string _department;
        private string _position;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int IDNumber
        {
            get { return _idnumber; }
            set { _idnumber = value; }
        }

        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public Employee(string name, int idNumber, string department, string position)
        {
            Name = name;
            IDNumber = idNumber;
            Department = department;
            Position = position;
        }

        public Employee()
        {
            Name = "";
            Department = "";
            Position = "";
            IDNumber = 0;
        }

        public override string ToString()
        {
            return string.Format("{0}       {1}         {2}         {3}", Name, IDNumber, Position, Department);
        }
    }
}
