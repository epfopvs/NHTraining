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
            int Num, Loop_Index;

            // Accepting user input or colleting base data
            Console.WriteLine("Enter Number to Display Maths Table");
            Num = Convert.ToInt32(Console.ReadLine());

            // Processing & Displaying output
            Console.WriteLine("Maths Table of " + Num);
            for (Loop_Index = 1; Loop_Index <= 10; Loop_Index++)
                Console.WriteLine(Num + "X" + Loop_Index + "=" + Num * Loop_Index);
            Console.ReadLine();

        }
    }
}
