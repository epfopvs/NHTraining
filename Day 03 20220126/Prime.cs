using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Day_03_20220126
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check givin number is prime or not
            int n, i;
            bool Prime_number = true;
            Console.WriteLine("Enter number for checking Prime Number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=2; Prime_number && i< Math.Sqrt(n);i++)
                if (n % i == 0)
                    Prime_number = false;
            if(Prime_number)
                Console.WriteLine(n+" is a prime Number");
             else
                Console.WriteLine(n + " is not a prime Number");
        }
     }
}