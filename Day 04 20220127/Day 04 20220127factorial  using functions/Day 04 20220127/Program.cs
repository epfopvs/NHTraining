using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_04_20220127
{
    class Program
    {
        public static int factorial(int n)
        {
            int i, factorial=1;
            for (i = 1; i <= n; i++)
                factorial = factorial * i;
            return factorial;
        }
        static void Main(string[] args)
        {
            int Number1, Number2, Number3;
            Console.WriteLine("Enter First Number for calculation of factorial ");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number for calculation of factorial ");
            Number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number for calculation of factorial ");
            Number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial of "+Number1+" is "+ factorial(Number1));
            Console.WriteLine("Factorial of " + Number2 + " is " + factorial(Number2));
            Console.WriteLine("Factorial of " + Number3 + " is " + factorial(Number3));
            Console.ReadLine();
        }

    }
}
