using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_04_20220127
{
    class Program
    {
        public static long Factorial(int n)
        {
            //Setting up i.e., Declare & initiation Section
            int Loop_Index;
            long Factorial = 1;
            // Processing 
            for (Loop_Index = 1; Loop_Index <= n; Loop_Index++)
                Factorial = Factorial * Loop_Index;
            // Return
            return Factorial;
        }
        static void Main(string[] args)
        {
            //Print Factorial using function
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
