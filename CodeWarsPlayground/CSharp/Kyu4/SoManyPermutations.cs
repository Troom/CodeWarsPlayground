namespace CodeWarsPlayground.CSharp.Kyu4
{
    //https://www.codewars.com/kata/5254ca2719453dcc0b00027d/train/csharp
    internal static class SoManyPermutations
    {
        public static List<string> SinglePermutations(string s)
        {
            List<string> result = new List<string>();
            Permute(s, 0, s.Length - 1, ref result);
            return result;
        }

        private static void Permute(string str, int startingPoint, int r, ref List<string> result)
        {
            if (startingPoint == r) { 
                if (!result.Contains(str))
                 result.Add(str);  
            }
            else
            {
                for (int i = startingPoint; i <= r; i++)
                {
                    str = Swap(str, startingPoint, i);
                    Permute(str, startingPoint + 1, r, ref result);
                    str = Swap(str, startingPoint, i);
                }
            }
        }
        public static string Swap(string a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
