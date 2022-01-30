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
            //Sum of digits of given number

            //Setting up i.e., Declare & initiation Section
            int Num,Sum_Dig,Temp_Num;

            // Accepting user input or colleting base data
            Console.WriteLine("Enter Number to find sum of digits");
            Num = Convert.ToInt32(Console.ReadLine());

            // Procssing  
            Temp_Num = Num;
            Sum_Dig = 0;
            while (Temp_Num > 0)
            {
                Sum_Dig += Temp_Num % 10;
                Temp_Num /= 10;
            }
            Console.WriteLine(" Sum of digits of "+Num+" is "+Sum_Dig);
            Console.ReadLine();
        }
    }
}
