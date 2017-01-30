using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        private string clientName;
        private int accountNumber;
        public string accountType;
        private double balance;
        private double deposit;
        private double withdraw;

        //Properties
        public virtual string ClientName
        {
            get { return this.clientName; }
            set { this.clientName = value; }
        }

        public virtual int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public double Deposit
        {
            get { return this.deposit; }
            set { this.deposit = value; }
        }

        public double Withdraw
        {
            get { return this.withdraw; }
            set { this.withdraw = value; }
        }

        //Constructors
        public Account(string clientName, int accountNumber)
        {
            this.clientName = clientName;
            this.accountNumber = accountNumber;
        }

        public Account(double balance, double deposit, double withdraw)
        {
            this.balance = balance;
            this.deposit = deposit;
            this.withdraw = withdraw;
        }

        public DateTime CurrentTime()
        {
            DateTime currentDateTime = DateTime.Now;
            return currentDateTime;
        }

        //Makes deposits and update balance
        public void DepositFunds()
        {
            CurrentTime();
            double depositAmount;
            Console.WriteLine("Please enter amount: ");
            depositAmount = Convert.ToDouble(Console.ReadLine());
            this.deposit = depositAmount;
            this.balance += deposit;
            Console.WriteLine(CurrentTime());
        }

        //Makes withdraws and update balance
        public void WithdrawFunds()
        {
            CurrentTime();
            double withdrawAmount;
            Console.WriteLine("Please enter amount: ");
            withdrawAmount = Convert.ToDouble(Console.ReadLine());
            this.withdraw = withdrawAmount;
            this.balance -= withdraw;
            Console.WriteLine(CurrentTime());
        }

        public virtual void ViewAccountBalance()
        {
            Console.WriteLine("Balance: {0}", balance);
        }

        public virtual void PrintClientInfo()
        {
            Console.WriteLine("Client Name: {0}", this.clientName);
            Console.WriteLine("Account Number: {0}", this.accountNumber);
        }


        public virtual void PrintAccountInfo()
        {
            Console.WriteLine("Date: {0}", CurrentTime());
            Console.WriteLine("Account Type: {0}", accountType);
            Console.WriteLine("Deposit Amount: + {0}", deposit);
            Console.WriteLine("Withdraw Amount: - {0}", withdraw);
            Console.WriteLine("Account Balance: {0}", balance);
            Console.WriteLine();
        }
    }
}
