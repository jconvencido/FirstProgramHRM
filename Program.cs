
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProgramHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingRefParameters();
            UsingParameters();
        }

        private static void UsingRefParameters()
        {
            int monthlyWage1 = 1234;
            int monthlyWage2 = 2000;
            int months1 = 12;
            int months2 = 8;
            int bonus = 300;

            var yearlyWage1 = CalculateYearlyWagebyRef(monthlyWage1, months1, ref bonus);
            Console.WriteLine(yearlyWage1);

            var yearlyWage2 = CalculateYearlyWage(monthlyWage2, months2, bonus);
            Console.WriteLine(yearlyWage2);
            //Console.WriteLine(ClosedPath(yearlyWage));
        }
        private static void UsingParameters()
        {
            int monthlyWage1 = 1234;
            int monthlyWage2 = 2000;
            int months1 = 12;
            int months2 = 8;
            int bonus = 300;

            var yearlyWage1 = CalculateYearlyWage(monthlyWage1, months1, bonus);
            Console.WriteLine(yearlyWage1);

            var yearlyWage2 = CalculateYearlyWage(monthlyWage2, months2, bonus);
            Console.WriteLine(yearlyWage2);
            //Console.WriteLine(ClosedPath(yearlyWage));
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            if (monthlyWage >= 2000)
            {
                bonus *= 2;
            }
            Console.WriteLine($"Bonus {bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
        public static int CalculateYearlyWagebyRef(int monthlyWage, int numberOfMonthsWorked,ref int bonus)
        {
            if (monthlyWage > 2000)
            {
                bonus *= 2;
            }
            Console.WriteLine($"Bonus {bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }





        static int ClosedPath(int number)
        {
            int ctr = 0;
            int[] closedPath = {1,0,0,0,1,0,1,0,2,1};
            int currentNumber;

            while (number > 0)
            {
                currentNumber = number % 10;

                ctr += closedPath[currentNumber];

                number /= 10;
            }
            return ctr;
        }
    }
}
