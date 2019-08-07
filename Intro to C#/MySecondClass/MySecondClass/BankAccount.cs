using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySecondClass
{
    class BankAccount
    {
        // Fields
        private string _name;
        private int _accountNumber;
        private decimal _balance;

        // readonly field
        private readonly int _myField;

        // Automatic property
        // You don't need to define a field because C# automatically generates it
        // Second, you don't need to provide code for the get and set operations. C# will generate it once it creates the fields
        public int MyProperty
        { get; private set; }
        // A property without a set is a read-only property
        // EX: {get;}

        // static member for counting objects when they are created
        private static int count; //= 0; initalizing static members

        // Count can not be set from the outside because the set is private
        public static int Count { get { return count; } private set { count = value; } }

        // static member fields need to be initialized in a static constructor
        static BankAccount()
        {
            Count = 0;
        }

        // Properties: Field Accessors (AKA Getters and setters)
        public string Name
        {
            get { return _name; }
            // Data validation in comments
            set { /* if (value.Trim() != String.Empty){ */_name = value; }
            // else issue an error
        }

        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        // Methods
        // Default Constructor (parameterless ctor)
        public BankAccount(): this("Unkown", 9999999, 0.0m)
            // Call the parameterized constructor with the default values to eliminate code redundancy. Purpose is to avoid duplicating what the main constructor
            // code does
        {
            //Name = "Unknown";
            //AccountNumber = 99999999;
            //Balance = 0.0m;
            //++Count;
        }

        // Parameterized ctor: intilizes the fields using the parameters
        public BankAccount(string name, int accountNumber, decimal balance)
        {
            this.Name = name;
            this.AccountNumber = accountNumber;
            this.Balance = balance;
            ++Count;
        }

        // another constructor
        public BankAccount(string name, int id)
            :this(name, id, 0.0m)
        {

        }

        // Method for depositing money into the account
        public void Deposit(decimal amount)
        {
            Balance += amount; // Updates the balance
        }

        // Method for withdrawing money from the account
        public void Withdraw(decimal amount)
        {
            if (Balance >= amount) Balance -= amount; // Updates the balance via deduction
            else MessageBox.Show("Insuffcient Funds");
        }

        // ToString Method
        public override string ToString()
        {
            // Converts/formats the object data to a string
            return string.Format("Name: {0}, Account Number: {1}, Balance:{2:c}", Name, AccountNumber, Balance);
        }
    }
}
