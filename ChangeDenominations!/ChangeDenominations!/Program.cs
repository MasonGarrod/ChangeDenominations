using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeDenominations_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Change Denominations \\

            // Declare Variables \\
            double costGiven;
            double moneyGiven;
            double change;
            int fiftyPence;
            int twentyPence;
            int tenPence;
            int fivePence;
            int twoPence;
            int onePence;

            // User enters the cost of the item \\
            costGiven = InputDouble("Enter the cost of the item in £ (0.00): ");

            // User enters the money that is given for the item \\
            moneyGiven = InputDouble("Enter the money given for the item in £ (0.00): ");

            // Works out the required change \\
            change = costGiven - moneyGiven;
            Console.WriteLine($"The change needed for this transaction is £{Math.Abs(change)}");

            // 50 pence \\
            fiftyPence = Convert.ToInt32(change / 0.5);
            change %= 0.50;
            Console.WriteLine($"Requires {Math.Abs(fiftyPence)} 50p's");
            
            // 20 pence \\
            twentyPence = Convert.ToInt32(change / 0.20);
            change %= 0.20;
            Console.WriteLine($"Requires {Math.Abs(twentyPence)} 20p's");

            // 10 pence \\
            tenPence = Convert.ToInt32(change / 0.10);
            change %= 0.10;
            Console.WriteLine($"Requires {Math.Abs(tenPence)} 10p's");

            // 5 pence \\
            fivePence = Convert.ToInt32(change / 0.05);
            change %= 0.05;
            Console.WriteLine($"Requires {Math.Abs(fivePence)} 5p's");

            // 2 pence \\
            twoPence = Convert.ToInt32(change / 0.02);
            change %= 0.02;
            Console.WriteLine($"Requires {Math.Abs(twoPence)} 2p's");

            // 1 pence \\
            onePence = Convert.ToInt32(change / 0.01);
            change %= 0.01;
            Console.WriteLine($"Requires {Math.Abs(onePence)} 1p's");

            // Exit \\
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static double InputDouble(string prompt)
        {
            // Declare Number \\
            double number;

            while (true)
            {
                try
                {
                    // User inputs double \\
                    Console.Write(prompt);
                    number = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return number;
        }
    }
}
