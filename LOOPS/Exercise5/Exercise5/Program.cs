using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord, secondWord, dots, result;
            int count, period, i;

            Console.Write("Enter a word #1: ");
            firstWord = Console.ReadLine();
            Console.Write("Enter a word #2: ");
            secondWord = Console.ReadLine();

            result = firstWord + "" + secondWord;
            count = result.Length;
            period = 0;

            if (count <= 30)
            {
                period = 30 - count;
                dots = "";

                for (i = 1; i <= period; i++)
                {
                    dots += ".";
                }

                Console.WriteLine(firstWord + dots + secondWord);
            }

            Console.ReadKey();
        }
    }
}
