using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_04_20220127
{
    
class Program
    {
        public static bool Armstrong(int Num1)
        {
            int Test_Num, Proc_Num, Rem_Dig, Loop_index, Num_Index, Dig_Pow;
            // Procesing 
            // find number of digits in given number
            for (Num_Index = 0, Proc_Num = Num1; Proc_Num > 0; Num_Index++, Proc_Num /= 10) ;
            // Suming each digit to power of number of digits 
            Test_Num = 0;
            Proc_Num = Num1;
            do
            {
                Rem_Dig = Proc_Num % 10;
                Dig_Pow = 1;
                for (Loop_index = 0; Loop_index < Num_Index; Loop_index++)
                    Dig_Pow = Dig_Pow * Rem_Dig;
                Test_Num = Test_Num + Dig_Pow;
                Proc_Num /= 10;
            } while (Proc_Num > 0);

            // Check & Displaying output
            if (Test_Num == Num1) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            //Armstrong number -Armstrong number definition is the number in any given number base, 
            //which forms the total of the same number, when each of its digits is raised to the 
            // power of the number of digits in the number.
            // 1, 2, 3, 4, 5, 6, 7, 8, 9, 153, 370, 371, 407, 1634, 8208, 9474, 54748
            
            //Setting up i.e., Declare & initiation Section
            int Num;
            
            // Accepting user input or colleting base data
            Console.WriteLine("Enter a Number for check ing Armstrong Number or not ");
            Num = Convert.ToInt32(Console.ReadLine());

           // Check & Displaying output
            if(Armstrong(Num))
                Console.WriteLine(Num+ " is a Armstrong number");
             else
                Console.WriteLine(Num + " is not a Armstrong number");
            Console.ReadLine();

        }
    }
}
