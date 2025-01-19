using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk1Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // display intro message
            Console.WriteLine("Interest Calculator Program");
            // take user input for principal
            Console.WriteLine("What is principal amount of the loan in dollars?");
            // delcare a double varable to hold user input
            double principal = Convert.ToDouble(Console.ReadLine());
            // take user input for rate
            Console.WriteLine("What is interest rate (input 0.05 for 5%)?");
            // delcare a double varable to hold user input
            double rate = Convert.ToDouble(Console.ReadLine());
            // take user input for years
            Console.WriteLine("What is period of loan in years?");
            // delcare a double varable to hold user input
            double time = Convert.ToDouble(Console.ReadLine());
            // display the total interest loan message with calculation
            Console.Write("Total interest of loan: " + principal * rate * time + " dollars.");
        }
    }
}
