using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_04_20220127
{
    class Program
    {
        public static long Factorial(long n)
        {
            // Processing & Return 
            if (n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            //Print Factorial using recursion
            //Setting up i.e., Declare & initiation Section
            int Num;

            // Accepting user input or colleting base data
            Console.WriteLine("Enter Number to calculate Factorial");
            Num = Convert.ToInt32(Console.ReadLine());

            // Processing i.e., calling function Displaying output
            Console.WriteLine("Factorial of given number " + Num+" is "+ Factorial(Num));
            Console.ReadLine();

        }
    }
}
