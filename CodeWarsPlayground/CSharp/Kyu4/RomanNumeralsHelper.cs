namespace CodeWarsPlayground.CSharp.Kyu4
{
    internal class RomanNumeralsHelper
    {

        public static string ToRoman(int n)
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

        public static int FromRoman(string s)
        {
            int sum = 0;
            Dictionary<char, int> romanNumbersDictionary = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            for (int i = 0; i < s.Length; i++)
            {
                char currentRomanChar = s[i];
                romanNumbersDictionary.TryGetValue(currentRomanChar, out int num);
                if (i + 1 < s.Length && romanNumbersDictionary[s[i + 1]] > romanNumbersDictionary[currentRomanChar])
                    sum -= num;
                else
                    sum += num;
            }
            return sum;
        }
    }
}
