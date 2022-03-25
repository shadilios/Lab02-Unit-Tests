using System;

namespace Test
{
    public class Program
    {
        public static decimal userBalance = 100;

        public static void Main(string[] args)
        {

            UserInterface();
            
        }


        public static decimal ViewBalance()
        {
            MakeLine();
            Console.WriteLine("- Welcome to balance page -");
            Console.WriteLine($" Your Current balance is: {userBalance} ");
            
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
            bool runProgram = true;

            while (runProgram)
            {
                MakeLine();
                Console.WriteLine("Welcome to the Bank Interface, please Select What you want to do:");
                Console.WriteLine("1 - View Balance");
                Console.WriteLine("2 - Withdraw");
                Console.WriteLine("3 - Deposit");
                Console.WriteLine("0 - Quit");

                var a = Console.ReadLine();

                switch (a)
                {
                    case "0":
                        Console.WriteLine("thanks for using the bank, Have a nice day");
                        runProgram = false;
                        break;

                    case "1":
                        ViewBalance();
                        break;

                    case "2":
                        Console.WriteLine("Input Withdraw amount: ");
                        decimal withd = Convert.ToDecimal(Console.ReadLine());

                        CheckWithdrawAmount(withd);

                        //Withdraw(withd);
                        break;

                    case "3":
                        Console.WriteLine("Input Deposit Amount: ");
                        decimal depo = Convert.ToDecimal(Console.ReadLine());
                        CheckDepositAmount(depo);
                        break;
                }
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

        public static void CheckWithdrawAmount(decimal x)
        {
            decimal withdrawnAmount = x;

            if (withdrawnAmount > userBalance)
            {
                Console.WriteLine($"Error: Can't process your transaction, the amount you asked to withdraw ({withdrawnAmount}) is MORE than the user balance ({userBalance})");
            }
            else if (withdrawnAmount < 0)
            {
                Console.WriteLine($"Error: Can't process your transaction, the amount you asked to withdraw ({withdrawnAmount}) is less than zero");
            }
            else
            {
                Withdraw(withdrawnAmount);
            }
        }

        public static void CheckDepositAmount(decimal x)
        {
            decimal depositAmount = x;

            if (depositAmount < 0)
            {
                Console.WriteLine($"Error: Can't process your transaction, the amount you asked to Deposit ({depositAmount}) is Less than ZERO");
            }
            else
            {
                Deposit(depositAmount);
            }
        }
        
    }
}
