using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class SavingsAccount : Account
    {

        private string clientName;
        private int accountNumber;

        //Properties
        public override string ClientName
        {
            get { return this.clientName; }
            set { this.clientName = value; }
        }

        public override int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        //Constructors
        public SavingsAccount(string clientName, int accountNumber) : base(12577.34, 0, 0)
        {
            this.ClientName = clientName;
            this.AccountNumber = accountNumber;
            this.accountType = "Savings";
        }

        //Methods
        public override void ViewAccountBalance()
        {
            Console.WriteLine("Account Type: {0}", accountType);
            base.ViewAccountBalance();
        }

        public void AccountSummary()
        {
            StreamWriter writer = new StreamWriter("savingsAccount.txt");

            using (writer)
            {
                writer.WriteLine("Client Name: {0}", clientName);
                writer.WriteLine("Account Number: {0}", accountNumber);
                writer.WriteLine("Account Type: {0}", accountType);
                writer.WriteLine("Deposit amount: +${0}     {1}", Deposit, CurrentTime());
                writer.WriteLine("Withdraw amount: -${0}     {1}", Withdraw, CurrentTime());
                writer.WriteLine("Account Balance: +${0}", Balance);
            }
        }
    }
}
