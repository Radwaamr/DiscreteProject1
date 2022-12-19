using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter starting number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ending number");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The prime numbers are :");

            int L = 0;

            for (int i = n1; i <= n2; i++)
            {
                for (int j = 1; j <= n2; j++)
                {
                    if (i % j == 0)
                        L++;
                }

                if (L == 2)
                    Console.WriteLine(i);
                L = 0;

            }


        }
        


    }
}
