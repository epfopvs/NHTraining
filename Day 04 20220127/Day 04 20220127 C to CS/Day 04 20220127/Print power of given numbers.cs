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
            //Prime number or not
            //Setting up i.e., Declare & initiation Section
            int Num, Loop_Index;
            bool Prime=true;

            // Accepting user input or colleting base data
            Console.WriteLine("Enter Number to prime or not ");
            Num = Convert.ToInt32(Console.ReadLine());
            
            // Processing 
            for (Loop_Index = 2; Loop_Index <= Math.Sqrt(Num); Loop_Index++)
                if(Num%Loop_Index==0)
                { Prime = false; break; }

            // Check & Displaying output
            if(Prime)
                Console.WriteLine(Num+" is Prime Number ");
             else
                Console.WriteLine(Num + " not a Prime Number ");
            Console.ReadLine();

        }
    }
}
