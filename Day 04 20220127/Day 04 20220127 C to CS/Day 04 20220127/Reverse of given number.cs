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
            //Reverse of given number

            //Setting up i.e., Declare & initiation Section
            int Num,R_Num,Temp_Num;

            // Accepting user input or colleting base data
            Console.WriteLine("Enter Number for reversing ");
            Num = Convert.ToInt32(Console.ReadLine());

            // Procssing 
            Temp_Num = Num;
            R_Num = 0;
            while (Temp_Num > 0)
            {
                R_Num=R_Num*10+Temp_Num % 10;
                Temp_Num /= 10;
            }
            Console.WriteLine(" Reverse of "+Num+" is "+R_Num);
            Console.ReadLine();
        }
    }
}
