using System;

namespace Test
{
    public class Program
    {
        public static decimal userBalance = 100;
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter 1 to start the Bank application or any random input if you're finished");
            var a = Console.ReadLine();

            if (a == "1")
            {
                UserInterface();
            }
            else
            {
                Console.WriteLine("thanks for using the bank, Have a nice day");
                return;
            }
            
        }


        public static decimal ViewBalance()
        {
            MakeLine();
            Console.WriteLine("- Welcome to balance page -");
            Console.WriteLine($" Your Current balance is: {userBalance} ");
            UserInterface();
            return userBalance;
        }
        
        public static decimal Withdraw(decimal x)
        {
            MakeLine();
            Console.WriteLine("- Welcome to withdraw page -");
            //Console.WriteLine($" Current Balance is {userBalance} ");

            decimal withdrawnAmount = x;

            //decimal temporaryBalance = userBalance;

            if (withdrawnAmount > userBalance || withdrawnAmount <= 0)
            {
                Console.WriteLine("Error, the amount of money you requested makes your balance less than or equal to 0");
            }
            else
            {
                //temporaryBalance = userBalance - withdrawnAmount;
                userBalance -= withdrawnAmount;
            }
            Console.WriteLine(" ");
            Console.WriteLine($" Transaction successfull, your current Balance is {userBalance} ");
            Console.WriteLine("");
            
            return userBalance;
            
        }

        public static decimal Deposit(decimal x)
        {
            MakeLine();
            Console.WriteLine("- Welcome to Deposit page -");

            decimal depositAmount = x;

            //decimal temporaryBalance = userBalance;

            if (depositAmount <= 0)
            {
                Console.WriteLine("Error, the amount of money you deposit less than or equal to 0");
            }
            else
            {
                //temporaryBalance = userBalance + depositAmount;
                userBalance += depositAmount;
            }
            Console.WriteLine(" ");
            Console.WriteLine($"Transaction successfull, your current Balance is {userBalance}");
            Console.WriteLine("");

            return userBalance;


        }

        public static void UserInterface()
        {
            Welcome();

        }
        
        //this is an extra function I added to make the code cleaner
        public static void Welcome()
        {
            MakeLine();
            Console.WriteLine("Welcome to the Bank Interface, please Select What you want to do:");
            Console.WriteLine("1 - View Balance");
            Console.WriteLine("2 - Withdraw");
            Console.WriteLine("3 - Deposit");
            Console.WriteLine("Anything else - Quit");

            var a = Console.ReadLine();
            //var a = "2";

            switch (a)
            {
                case "1": ViewBalance(); 
                    break;

                case "2":
                    Console.WriteLine("Input Withdraw amount: ");
                    decimal withd = Convert.ToDecimal(Console.ReadLine());
                    Withdraw(withd);
                    break;

                case "3":
                    Console.WriteLine("Input Deposit Amount: ");
                    decimal depo = Convert.ToDecimal(Console.ReadLine());
                    Deposit(depo);
                    break;

                default: Console.WriteLine("thanks for using the bank, Have a nice day");
                    break;
            }
        }


        public static void MakeLine()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }

        
    }
}
