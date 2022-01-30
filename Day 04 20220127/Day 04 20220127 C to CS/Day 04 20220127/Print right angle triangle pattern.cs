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
            //Print stars(*) in pattern (right angle triangle pattern)

            //Setting up i.e., Declare & initiation Section
            int Num_Rows, Loop_Index1, Loop_Index2;

            // Accepting user input or colleting base data
            Console.WriteLine("Enter Number of Rows ");
            Num_Rows = Convert.ToInt32(Console.ReadLine());

            // Procssing & Display Output

            for (Loop_Index1 = 0; Loop_Index1 < Num_Rows; Loop_Index1++)
            {
                for (Loop_Index2 = 0; Loop_Index2 <= Loop_Index1; Loop_Index2++)
                    Console.Write("* ");
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
