using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "string reversal";
            var comparisonTest = "lasrever gnirts";

            var reverseReturn = ReverseWithFor(text);
            
            //var reverseReturn = ReverseWithAggregate(text);

            if (IsEqual(comparisonTest, reverseReturn))
                Console.WriteLine(string.Format("Congrats, the text {0} is {1} in Reversal Mode!", text, reverseReturn));
            else
                Console.WriteLine("Text is different, sorry!");

            Console.ReadLine();
        }

        private static string ReverseWithFor(string text)
        {
            var textArr = text.ToArray();
            var reverseReturn = String.Empty;

            for (int i = 1; i <= textArr.Length; i++)
            {
                var letter = textArr[textArr.Length - i];

                reverseReturn += letter;
            }

            return reverseReturn;
        }

        private static bool IsEqual(string text, string textComparison)
        {
            return text == textComparison;
        }

        private static string ReverseWithAggregate(string text)
        {
            var arr = text.ToArray();
            var reversed = arr.Aggregate("", (s, c) => c + s);

            return reversed;
        }
    }
}
