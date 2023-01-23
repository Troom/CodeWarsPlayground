using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsPlayground.CSharp.Kyu6
{
    internal static class RomanConvert
    {
        public static string Solution(int n)
        {
            string result = "";

            RomeConverter(ref n, ref result, 1000, "M");
            RomeConverter(ref n, ref result, 900, "CM");
            RomeConverter(ref n, ref result, 500, "D");
            RomeConverter(ref n, ref result, 400, "CD");
            RomeConverter(ref n, ref result, 100, "C");
            RomeConverter(ref n, ref result, 90, "XC");
            RomeConverter(ref n, ref result, 50, "L");
            RomeConverter(ref n, ref result, 40, "XL");
            RomeConverter(ref n, ref result, 10, "X");
            RomeConverter(ref n, ref result, 9, "IX");
            RomeConverter(ref n, ref result, 8, "VIII");
            RomeConverter(ref n, ref result, 7, "VII");
            RomeConverter(ref n, ref result, 6, "VI");
            RomeConverter(ref n, ref result, 5, "V");
            RomeConverter(ref n, ref result, 4, "IV");
            RomeConverter(ref n, ref result, 3, "III");
            RomeConverter(ref n, ref result, 2, "II");
            RomeConverter(ref n, ref result, 1, "I");

            return result;
        }

        private static void RomeConverter(ref int n, ref string result, int value, string letter)
        {
            var tmp = n / value;
            n -= (tmp * value);

             while (tmp > 0)
            {
                result += letter;
                tmp--;
            };
        }
    }
}
