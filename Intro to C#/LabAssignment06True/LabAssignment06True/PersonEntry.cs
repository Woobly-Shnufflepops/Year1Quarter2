/* Name: Matthew Powers
 * Date: 6/2/17
 * Class: CSI 154
 * Assignment: Lab Assignment 6
 * Description: Creates the PersonEntry Class with a constructor and a ToString override
 */
namespace LabAssignment06True
{
    class PersonEntry
    {
        // Creates the 3 fields
        private string _name;
        private string _email;
        private string _phoneNumber;

        // Creates the properties for the 3 fields
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        // Creates the constructor which allows assignment to the fields
        public PersonEntry(string name, string email, string phonenumber)
        {
            _name = name;
            _email = email;
            _phoneNumber = phonenumber;
        }

        // ToString override that gives the name when called
        public override string ToString()
        {
            return string.Format("Name: {0}", Name);

        }
    }
}
