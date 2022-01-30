using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_04_20220127
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Setting up i.e., Declare & initiation Section
            int Num, Loop_Index, Factorial=1;

            // Accepting user input or colleting base data
            Console.WriteLine("Enter Number to Calculate Factorial");
            Num = Convert.ToInt32(Console.ReadLine());

            // Processing 
            for (Loop_Index = 1; Loop_Index <= Num; Loop_Index++)
                Factorial = Factorial * Loop_Index;
            // Displaying output
            Console.WriteLine("Factorial of " + Num+" is :"+ Factorial);
            Console.ReadLine();
        }
    }
}
