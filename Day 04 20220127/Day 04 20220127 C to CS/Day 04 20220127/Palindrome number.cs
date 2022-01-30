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
            //Palindrome number

            //Setting up i.e., Declare & initiation Section
            int Num,R_Num,Temp_Num;

            // Accepting user input or colleting base data
            Console.WriteLine("Enter a Number for Palindrome number checking ");
            Num = Convert.ToInt32(Console.ReadLine());

            // Procssing 
            Temp_Num = Num;
            R_Num = 0;
            while (Temp_Num > 0)
            {
                R_Num=R_Num*10+Temp_Num % 10;
                Temp_Num /= 10;
            }

            // Display Output
            if (Num == R_Num)
                Console.WriteLine(Num + " is a Palidrome Number");
             else
                Console.WriteLine(Num + "is not a Palidrome Number");
            Console.ReadLine();
        }
    }
}
