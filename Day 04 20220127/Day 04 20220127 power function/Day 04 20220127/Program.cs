using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_04_20220127
{
    class Program
    {
        public static int Power(int Base_Num, int Exp_Num)
        {
            int i, Power_Val = 1;
            for (i = 1; i <= Exp_Num; i++)
                Power_Val = Power_Val * Base_Num;
            return Power_Val;
        }
        static void Main(string[] args)
        {
            int Base1, Expo1,Base2, Expo2,Base3,Expo3;
            Console.WriteLine("Enter First set of Numbers for calculation of Power Base and Exponent ");
            Base1 = Convert.ToInt32(Console.ReadLine());
            Expo1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number for calculation of Power Base and Exponent ");
            Base2 = Convert.ToInt32(Console.ReadLine());
            Expo2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number for calculation of Power Base and Exponent ");
            Base3 = Convert.ToInt32(Console.ReadLine());
            Expo3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Base1+" Power of " + Expo1 + " is " + Power(Base1,Expo1));
            Console.WriteLine(Base2 + " Power of " + Expo2 + " is " + Power(Base2, Expo2));
            Console.WriteLine(Base3 + " Power of " + Expo3 + " is " + Power(Base3, Expo3));
            Console.ReadLine();
        }
    }
}
