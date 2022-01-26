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
            // print factors of a given number using for loop
            int n, i;
            Console.WriteLine("Enter a Number to determine factors of it ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factors of " + n + " are ");
            for (i = 1; i <= n; i++)
                if(n%i==0)
                    Console.WriteLine(i);
            
            Console.ReadLine();
        }
    }
}
