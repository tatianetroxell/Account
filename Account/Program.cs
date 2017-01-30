using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to First Bank Online Account!");
            Console.WriteLine("Please enter your name:");
            string clientName = Console.ReadLine();//Assign the value entered by the user to the variable clientName
            int accountNumber = 456720785;//hard code the accountNumber

            //Create an new object of Account, CheckingAccount, ReserveAccount, SavingsAccount
            //The values clientName and accountNumber are assigned to them, they will be the same for all of them
            Account account = new Account(clientName, accountNumber);
            CheckingAccount checkingAccount = new CheckingAccount(clientName, accountNumber);
            ReserveAccount reserveAccount = new ReserveAccount(clientName, accountNumber);
            SavingsAccount savingsAccount = new SavingsAccount(clientName, accountNumber);

            string userAnswer;

            //this loop will run while the user wants to make transactions
            do
            {
                //Menu with options for the user to choose, based on their option program will run different transactions
                Console.WriteLine("What would like to do?");
                Console.WriteLine("1 - View Client Information");
                Console.WriteLine("2 - View Account Balance");
                Console.WriteLine("3 - Deposit Funds");
                Console.WriteLine("4 - Withdraw Funds");
                int input = int.Parse(Console.ReadLine());

                Console.WriteLine();

                if (input == 1)
                {
                    //Print client name and account number
                    account.PrintClientInfo();
                }
                //Show account balance the client chooses
                else if (input == 2)
                {
                    Console.WriteLine("Please Select Account Type:");
                    Console.WriteLine("1 - Checking Account");
                    Console.WriteLine("2 - Reserve Account");
                    Console.WriteLine("3 - Savings Account");
                    int inputAccountType = int.Parse(Console.ReadLine());
                    switch (inputAccountType)
                    {
                        case 1:
                            checkingAccount.ViewAccountBalance();
                            break;
                        case 2:
                            reserveAccount.ViewAccountBalance();
                            break;
                        case 3:
                            savingsAccount.ViewAccountBalance();
                            break;
                        default:
                            Console.WriteLine("Invalid Selection!");
                            break;
                    }
                }
                //Deposit amount user enters to the account the user chooses
                else if (input == 3)
                {
                    Console.WriteLine("Please Select Account to Deposit:");
                    Console.WriteLine("1 - Checking");
                    Console.WriteLine("2 - Reserve");
                    Console.WriteLine("3 - Savings");
                    int inputAccountType = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (inputAccountType)
                    {
                        case 1:
                            checkingAccount.DepositFunds();
                            checkingAccount.ViewAccountBalance();
                            break;
                        case 2:
                            reserveAccount.DepositFunds();
                            reserveAccount.ViewAccountBalance();
                            break;
                        case 3:
                            savingsAccount.DepositFunds();
                            savingsAccount.ViewAccountBalance();
                            break;
                        default:
                            Console.WriteLine("Invalid Selection!");
                            break;
                    }
                }
                //Withdraw amount user enters from the account the user chooses
                else if (input == 4)
                {
                    Console.WriteLine("Please Select Account to Withdraw:");
                    Console.WriteLine("1 - Checking");
                    Console.WriteLine("2 - Reserve");
                    Console.WriteLine("3 - Savings");
                    int inputAccountType = int.Parse(Console.ReadLine());
                     Console.WriteLine();
                    switch (inputAccountType)
                    {
                        case 1:
                            checkingAccount.WithdrawFunds();
                            checkingAccount.ViewAccountBalance();
                            break;
                        case 2:
                            reserveAccount.WithdrawFunds();
                            reserveAccount.ViewAccountBalance();
                            break;
                        case 3:
                            savingsAccount.WithdrawFunds();
                            savingsAccount.ViewAccountBalance();
                            break;
                        default:
                            Console.WriteLine("Invalid Selection!");
                            break;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Would you like to make another transaction (Y/N)?");
                userAnswer = Console.ReadLine();

                Console.WriteLine();

                //Uses StreamWriter to create a summary of each account and save in a text file
                checkingAccount.AccountSummary();
                reserveAccount.AccountSummary();
                savingsAccount.AccountSummary();

            } while (userAnswer.ToUpper() == "Y" || userAnswer.ToUpper() == "YES");
            //end of do while loop

            Console.WriteLine("Thank you for being our client!");
        }
    }
}
