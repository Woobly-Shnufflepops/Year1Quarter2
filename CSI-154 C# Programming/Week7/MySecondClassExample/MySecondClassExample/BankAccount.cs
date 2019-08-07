
using System.Windows.Forms;

namespace MySecondClassExample
{
    class BankAccount
    {

        // fields
        private string _name;
        private int _accountNumber;
        private decimal _balance;

        // Properties: field accessors
        // getters and setters
        public string Name
        {
            get { return _name; }
            set { _name = value; }
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
            Name = "Unknown";
            AccountNumber = 99999999;
            Balance = 0.0m;
        }

        // Paramterized ctor: initializes the fields using the parameters
        public BankAccount(string name, int accountNumber, decimal balance)
        {
            Name = name;
            AccountNumber = accountNumber;
            Balance = balance;
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

        // ToString method
        public override string ToString()
        {
            // converts/formats the object data to a string
            return string.Format("Name:{0}, Acc#:{1}, Balance:{2:c}", 
                Name, AccountNumber, Balance);
        }

    }
}
