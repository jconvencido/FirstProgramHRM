using System;
using System.Collections.Generic;

namespace FirstProgramHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = ClosedPath(8888);
            Console.ReadLine();
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
