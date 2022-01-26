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
            // Compute factorial of a number using for loop
            int n, i;
            long Factorial = 1;
            Console.WriteLine("Enter a Number to Compute factorial");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
                Factorial = Factorial * i;
            Console.WriteLine("Factorial of "+n+" is "+Factorial);
            Console.ReadLine();
        }
    }
}
