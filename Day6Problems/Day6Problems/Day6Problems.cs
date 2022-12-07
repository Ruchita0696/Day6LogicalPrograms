using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Problems
{
    internal class Day6Problems
    {
        public void Prime_Number()
        {
            int n, i, sum;
            Console.WriteLine("");
            Console.Write("Check whether a given number is prime number or not:\n");
            Console.Write("--------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the  number : ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            Console.Write("The positive divisor  : ");
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.Write("{0}  ", i);
                }
            }
            Console.Write("\nThe sum of the divisor is : {0}", sum);
            if (sum == n)
                Console.Write("\nSo, the number is prime.");
            else
                Console.Write("\nSo, the number is not prime.");
            Console.Write("\n");
        }
    }
}
