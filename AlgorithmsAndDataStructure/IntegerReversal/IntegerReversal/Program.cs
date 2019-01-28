using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 15;
            //var number = 981;
            //var number = 500;
            //var number = -15;
            //var number = -90;

            var returnedNumber = ReverseInt(number);

            Console.WriteLine("Number reversed " + returnedNumber);

            Console.ReadLine();
        }

        private static int ReverseInt(int number)
        {
            if (number == 0)
                return number;

            var reverseReturn = ReverseWithAggregate(Math.Abs(number).ToString());

            var reverseInt = int.Parse(reverseReturn);

            return number > 0 ? reverseInt : reverseInt * -1;
        }

        private static string ReverseWithAggregate(string text)
        {
            var arr = text.ToArray();
            var reversed = arr.Aggregate("", (s, c) => c + s);

            return reversed;
        }
    }
}
