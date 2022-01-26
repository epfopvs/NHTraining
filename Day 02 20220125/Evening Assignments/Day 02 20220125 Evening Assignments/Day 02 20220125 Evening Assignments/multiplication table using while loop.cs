using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_02_20220125_Evening_Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            // print multiplication table of a given number using while loop
            int n, i;
            Console.WriteLine("Enter a Number to print multiplication table of it");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Table of " + n + " is ");
            i = 1;
            while(i<=10)
            {
                Console.WriteLine(n + "X" + i + "=" + n * i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
