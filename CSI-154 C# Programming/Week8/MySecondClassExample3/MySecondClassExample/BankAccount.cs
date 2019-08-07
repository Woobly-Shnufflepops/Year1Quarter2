using System;
using System.Windows.Forms;
using System.Text;

namespace MySecondClassExample
{
    class BankAccount
    {

        // fields
        private string _name;
        private int _accountNumber;
        private decimal _balance;

        // readonly field
        private readonly int _myField;

        // static member foer counting objects when they are created
        //private static int count /*= 0*/; // intializaing static members
        // automatic 
        public static int Count
        {
            get;
            // can't be set from outside the class
            private set;
        }
        // static member fields need to be initialized
        //  in a static constructor
       static BankAccount()
        {
            Count = 0;
        }

        // Automatic property:
        // you don't need to define a field (C# will automatically
        // generate it)
        // you don't to provide code for the get and set operations
        // (C# generates it once it creates the backing field)
        public int MyProperty
        { get; } 
        // a property without a set operation is a read-only 
        // property
        // Properties: field accessors
        // getters and setters
        public string Name
        {
            get { return _name; }
            set {
                if (value.Trim() != String.Empty) // data validation
                    _name = value;
                else
                {
                    // issue an error 
                }
             }
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
        // Default ctor (parameterless ctor)
        public BankAccount()
        {
            _name = "Unknown";
            AccountNumber = 99999999;
            Balance = 0.0m;
            ++Count;
        }

        // Paramterized ctor: initializes the fields using the parameters
        public BankAccount(string name, int accountNumber, decimal balance)
        {
            Name = name;
            AccountNumber = accountNumber;
            Balance = balance;
            ++Count;
        }

        // method for depositing money into the account
        public void Deposit(decimal amount)
        {
            Balance += amount; // update the balance
        }

        // method for withdrawing monery from the account
        public void Withdraw(decimal amount)
        {
            if (amount <= Balance)
                Balance -= amount; // deduct the amount
            else
                MessageBox.Show("Insufficient funds!!!");
        }

        //ToString method
        public override string ToString()
        {
            // converts/formats the object data to a string
            return string.Format("Name:{0}, Acc#:{1}, Balance:{2:c}",
                Name, AccountNumber, Balance);
        }

    }
}
