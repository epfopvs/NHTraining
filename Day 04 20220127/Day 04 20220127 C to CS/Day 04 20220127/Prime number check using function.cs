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
            //Prime number check using function
            //Setting up i.e., Declare & initiation Section
            int Num;
            bool Prime;

            // Accepting user input or colleting base data
            Console.WriteLine("Enter Number to prime or not ");
            Num = Convert.ToInt32(Console.ReadLine());

            // calling function 
            Prime = Prime_Fun(Num);

            // Check & Displaying output
            if(Prime)
                Console.WriteLine(Num+" is Prime Number ");
             else
                Console.WriteLine(Num + " not a Prime Number ");
            Console.ReadLine();

        }
    }
}
