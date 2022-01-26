using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_01_20220124_Morning_Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            int First_num, Second_Num, Sum;
            Console.WriteLine("Enter First Number for addition");
            First_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number for addition");
            Second_Num = Convert.ToInt32(Console.ReadLine());
            Sum = First_num + Second_Num;
            Console.WriteLine("Sum of Given Two numbers"+First_num+" and "+Second_Num+" is "+Sum);
            Console.ReadLine();
        }
    }
}
