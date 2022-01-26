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
            // Compute Sum of First n Natural Numbers by using for loop & taking user input
            int n, Sum = 0, i;
            Console.WriteLine("Enter a Number to Compute Sum of First n Natural Numbers");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
                Sum = Sum + i;
            Console.WriteLine("Sum of First Natural number upto " + n + " is " + Sum);
            Console.ReadLine();
        }
    }
}
