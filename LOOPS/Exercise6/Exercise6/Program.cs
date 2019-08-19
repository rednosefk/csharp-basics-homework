using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;


            for (i = 1; i <= 110; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(" Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write(" Buzz ");
                }
                
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write(" FizzBuzz ");
                }
                else
                {
                    Console.Write(" " + i + " ");
                }

            }

            Console.ReadKey();
        }
    }
}
