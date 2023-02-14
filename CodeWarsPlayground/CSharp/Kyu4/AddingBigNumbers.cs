using System.Numerics;
using System.Text;

namespace CodeWarsPlayground.CSharp.Kyu4
{
    internal static class AddingBigNumbers
    {
        //https://www.codewars.com/kata/525f4206b73515bffb000b21/train/csharp

        public static string Add(string a, string b) => (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
        
        
        //About 20% faster result.
        public static string AddPerformance(string a, string b)
        {
            var reverseResult = new StringBuilder();
            int aLength = a.Length, bLength = b.Length, length = aLength > bLength ? aLength : bLength, carry = 0;
            a = a.PadLeft(length, '0');
            b = b.PadLeft(length, '0');

            for (var index = length - 1; index >= 0; index--)
            {
                var sum = carry + a[index] - 48 + b[index] - 48;
                reverseResult.Append(sum % 10);
                carry = sum / 10;
            }

            if (carry > 0)
                reverseResult.Append(1);

            var result = reverseResult.ToString().ToCharArray();

            Array.Reverse(result);

            return String.Join(String.Empty, result);
        }

    }
}
