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
            int Base_value, Exponent_value,Loop_index;
            long Power_value=1;
            Console.WriteLine("Enter number for Base whose power to be calculated");
            Base_value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of exponent to be calculatepower");
            Exponent_value = Convert.ToInt32(Console.ReadLine());
            for (Loop_index = 1; Loop_index <= Exponent_value; Loop_index++)
                Power_value = Power_value * Base_value;
            Console.WriteLine(Base_value + " Power " + Exponent_value + " is " + Power_value);
            Console.ReadLine();
        }
    }
}
