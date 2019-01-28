using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //2
            //Fizz
            //4
            //Buzz

            FizzBuzz(-100);

            Console.ReadLine();
        }

        private static void FizzBuzz(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;

                if (fizz && buzz)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (fizz)
                {
                    Console.WriteLine("Fizz");
                }
                else if (buzz)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
