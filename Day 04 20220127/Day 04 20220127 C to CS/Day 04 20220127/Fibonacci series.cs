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
            //Fibonacci series
            //Setting up i.e., Declare & initiation Section
            int Num,F_Num=0,S_Num=1,Loop_index,Temp_Num;
            
            // Accepting user input or colleting base data
            Console.WriteLine("Print how many of first Fibonacci numbers");
            Num = Convert.ToInt32(Console.ReadLine());
            
            // Procesing & Displaying output
            Console.WriteLine("First "+Num+" Fibonacci numbers are ");
            Console.WriteLine(F_Num);
            Console.WriteLine(S_Num);
            for (Loop_index = 2; Loop_index < Num; Loop_index++)
            {
                Console.WriteLine(F_Num + S_Num);
                Temp_Num = F_Num;
                F_Num = S_Num;
                S_Num = F_Num + Temp_Num;
            }

            Console.ReadLine();

        }
    }
}
