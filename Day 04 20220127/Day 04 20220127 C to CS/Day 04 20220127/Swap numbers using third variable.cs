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
            //Swap numbers without using third variable

            //Setting up i.e., Declare & initiation Section
            int Num1,Num2;

            // Accepting user input or colleting base data
            Console.WriteLine("Enter Two Numbers for Swaping them  ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Num2 = Convert.ToInt32(Console.ReadLine());

            // Procssing 
            Num1 = Num1+Num2;
            Num2 = Num1 - Num2;
            Num1 = Num1 - Num2;

            // Display Output
            Console.WriteLine("Swaped and numbers are "+Num1+" & "+Num2);
            Console.ReadLine();
        }
    }
}
