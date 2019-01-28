using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "01233210";

            var isPalindrome = Palindrome(text);

            Console.WriteLine("Is palindrome? " + isPalindrome);
            Console.ReadLine();
        }

        private static bool Palindrome(string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;

            var textReversed = ReverseWithAggregate(text);

            if (textReversed.Length != text.Length)
                return false;

            return IsPalindrome(text, textReversed);

            //// This method doesn't verify all the text, the save machine processing
            //// It only verifies the half of the length.
            //return IsPalindromeHalfVerification(text, textReversed);
        }

        private static bool IsPalindrome(string text, string textReversed)
        {
            var arrText = text.ToArray();
            var arrTextReversed = textReversed.ToArray();

            for (int i = 0; i < arrText.Length; i++)
            {
                if (arrText[i].ToString().ToLower() != arrTextReversed[i].ToString().ToLower())
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsPalindromeHalfVerification(string text, string textReversed)
        {
            var arrText = text.ToArray();
            var arrTextReversed = textReversed.ToArray();

            var limitToCheck = (arrText.Length / 2) + 1;

            for (int i = 0; i < limitToCheck; i++)
            {
                if (arrText[i].ToString().ToLower() != arrTextReversed[i].ToString().ToLower())
                {
                    return false;
                }
            }

            return true;
        }

        private static string ReverseWithAggregate(string text)
        {
            var arr = text.ToArray();
            var reversed = arr.Aggregate("", (s, c) => c + s);

            return reversed;
        }


    }
}
