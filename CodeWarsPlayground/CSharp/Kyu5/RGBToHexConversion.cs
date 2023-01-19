using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsPlayground.CSharp.Kyu5
{
    internal class RGBToHexConversion
    {
        //V1
        private static readonly Dictionary<int, string> HexTable = new Dictionary<int, string>()
        {
            {0,"0"},
            {1,"1"},
            {2,"2"},
            {3,"3"},
            {4,"4"},
            {5,"5"},
            {6,"6"},
            {7,"7"},
            {8,"8"},
            {9,"9"},
            {10,"A"},
            {11,"B"},
            {12,"C"},
            {13,"D"},
            {14,"E"},
            {15,"F"},
        };
        public static int IsLowerThan255(int input) => input < 255 ? input : 255;
        public static int IsGreaterThan0(int input) => input > 0 ? input : 0;


        public static string ConvertToHex(int input)
        {
            input = IsLowerThan255(input);
            input = IsGreaterThan0(input);
            var x = Decimal.Divide(input, 16);
            var firstChar = Decimal.ToInt32(x);
            var secondChar = Convert.ToInt32((x - firstChar) * 16);

            return HexTable[firstChar] + HexTable[secondChar];
        }


        public static string Rgb(int r, int g, int b)
        {
            string result = ConvertToHex(r);
            result += ConvertToHex(g);
            result += ConvertToHex(b);
            return result;
        }


        //V2
        public static string RgbClamp(int r, int g, int b)
        {
            return Math.Clamp(r, 0, 255).ToString("X2") + Math.Clamp(g, 0, 255).ToString("X2") + Math.Clamp(b, 0, 255).ToString("X2");
        }


        //V3
        public static string RgbToByte(int r, int g, int b)
        {
            return string.Format("{0:X2}{1:X2}{2:X2}", ToByte(r), ToByte(g), ToByte(b));
        }

        static int ToByte(int x)
        {
            if (x < 0) return 0;
            else if (x > 255) return 255;
            else return x;
        }

    }
}
