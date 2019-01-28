using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMostCommonlyUsed
{
    class Program
    {
        static void Main(string[] args)
        {
            // e
            var text = "AAAbbCCddEEE";

            //MaxChar(“abcccccccd”) == “c”
            //var text = "abcccccccd";

            //MaxChar(“apple 1231111”) == “1”
            //var text = "apple 1231111";

            Console.WriteLine("Text is: " + text);
            Console.WriteLine();

            var character = MaxChar(text);
            
            Console.WriteLine("The character(s) most commonly used is: " + character);
            Console.ReadLine();
        }

        private static string MaxChar(string text)
        {
            var arr = text.ToArray();

            var dic = new Dictionary<char, int>();

            foreach (var character in arr)
            {
                if (!dic.ContainsKey(character))
                {
                    dic[character] = 1;
                }
                else
                {
                    dic[character]++;
                    
                }
            }

            var maxChar = ReturnCharacterMostCommon(dic);

            return maxChar;
        }

        private static string ReturnCharacterMostCommon(Dictionary<char, int> dictionary)
        {
            var mostCommon = string.Empty;
            var previousValue = 0;

            foreach (var character in dictionary.OrderByDescending(d => d.Value))
            {
                if (string.IsNullOrEmpty(mostCommon))
                {
                    mostCommon = character.Key.ToString();
                    previousValue = character.Value;
                    continue;
                }

                if (character.Value == previousValue)
                {
                    mostCommon += ", " + character.Key;
                }
                else
                    break;
            }

            return mostCommon;
        }
    }
}
