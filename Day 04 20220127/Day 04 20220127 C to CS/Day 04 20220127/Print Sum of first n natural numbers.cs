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
            //Print Sum of first n natural numbers
            //Setting up i.e., Declare & initiation Section
            int Num, Loop_Index,Sum=0;

            // Accepting user input or colleting base data
            Console.WriteLine("Enter Number to calculate sum of natural number upto it and Display");
            Num = Convert.ToInt32(Console.ReadLine());

            // Processing & Displaying output
            for (Loop_Index = 1; Loop_Index <= Num; Loop_Index++)
                Sum = Sum + Loop_Index;

            // Processing & Displaying output
            Console.WriteLine("Sum of Nartual numbers upto "+Num+" is "+Sum);
            Console.ReadLine();

        }
    }
}
