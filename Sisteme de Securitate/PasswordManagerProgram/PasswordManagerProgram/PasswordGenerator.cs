using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManagerProgram
{
    public enum Level { WEAK, MEDIUM, STRONG };
    public static class PasswordGenerator
    {
        // 0-9
        // a-z
        // A-Z
        // ([{/@#$%^&*
        // length

        private static Random rnd = new Random();
        private static char[] symbols = { '!', '@', '#', '$', '%', '&', '*', '(', ')', '[', ']', '{', '}', '+', '-', '.', ':', ';' };
        public static string Generate(Level level = Level.MEDIUM)
        {
            StringBuilder str = new StringBuilder();
            int length, lowerCharsCount, upperCharsCount, numberCharsCount, symbolsCharsCount;

            if (level == Level.WEAK)
            {
                length = rnd.Next(5, 8);

                lowerCharsCount = length / 3;
                upperCharsCount = length / 3 + length % 3;
                numberCharsCount = length / 3;

                symbolsCharsCount = 0;
            }
            else if (level == Level.MEDIUM)
            {
                length = rnd.Next(8, 15);

                /*
                 * 1/4 lower
                 * 1/4 upper
                 * 1/4 de numere
                 * 1/4 de simboluri
                 */
                /*
                 * ex. length = 15
                   lower 3
                   upper 3
                   number 3+3
                   simbol 3
                 */
                lowerCharsCount = length / 4;
                upperCharsCount = length / 4;
                numberCharsCount = length / 4 + length % 4;
                symbolsCharsCount = length / 4;
            }
            else
            {
                length = rnd.Next(15, 20);

                /*
                 * 1/4 lower
                 * 1/4 upper
                 * 1/4 de numere
                 * 1/4 de simboluri + 1%4
                 */
                lowerCharsCount = length / 4;
                upperCharsCount = length / 4;
                numberCharsCount = length / 4;
                symbolsCharsCount = length / 4 + length % 4;
            }

            for (int i = 0; i < lowerCharsCount; i++)
                str.Append((char)('a' + rnd.Next(26)));

            for (int i = 0; i < upperCharsCount; i++)
                str.Append((char)('A' + rnd.Next(26)));

            for (int i = 0; i < numberCharsCount; i++)
                str.Append(rnd.Next(10));

            for (int i = 0; i < symbolsCharsCount; i++)
                str.Append(symbols[rnd.Next(symbols.Length)]);

            for (int i = str.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i);
                char temp = str[j];
                str[j] = str[i];
                str[i] = temp;
            }
            return str.ToString();
        }
    }
}
