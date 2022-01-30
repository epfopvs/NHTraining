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
            //Print factors of given number
            //Setting up i.e., Declare & initiation Section
            int Num, Loop_Index;

            // Accepting user input or colleting base data
            Console.WriteLine("Enter Number to Display factors of it");
            Num = Convert.ToInt32(Console.ReadLine());

            // Processing & Displaying output
            Console.WriteLine("Factors of "+Num+" are ");
            for (Loop_Index=1;Loop_Index<=Math.Sqrt(Num);Loop_Index++)
                if(Num%Loop_Index==0)
                    Console.WriteLine(Loop_Index+","+Num/Loop_Index);
            Console.ReadLine();

        }
    }
}
