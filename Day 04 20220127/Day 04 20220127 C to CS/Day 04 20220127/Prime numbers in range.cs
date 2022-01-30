using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_04_20220127
{
    class Program
    {
    public static bool Prime_Fun(int n)
        {
            //Setting up i.e., Declare & initiation Section
            int Loop_Index;
            
            //Processing & Return value
            for (Loop_Index = 2; Loop_Index <= Math.Sqrt(n); Loop_Index++)
                if (n % Loop_Index == 0) return false;
            return true;
        }
        static void Main(string[] args)
        {
            //Prime numbers in range
            //Setting up i.e., Declare & initiation Section
            int From_Num,To_Num,Loop_index;
            
            // Accepting user input or colleting base data
            Console.WriteLine("To print prime number in Range. Enter starting Number ");
            From_Num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Ending Number ");
            To_Num = Convert.ToInt32(Console.ReadLine());

            // Calling function i.e., Check & Displaying output
            Console.WriteLine("Prime_Fun Number from"+From_Num+" to "+To_Num);
            for(Loop_index=From_Num;Loop_index<=To_Num;Loop_index++)
                if (Prime_Fun(Loop_index))
                    Console.WriteLine(Loop_index);
            Console.ReadLine();

        }
    }
}
