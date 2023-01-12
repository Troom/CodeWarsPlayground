namespace CodeWarsPlayground.CSharp.Kyu7
{
    //Complete the function that accepts a string parameter, and reverses each word in the string.
    //All spaces in the string should be retained.

    internal static class ReverseWordsClass
    {

        public static string ReverseWords(string str) //Bad -> I need to reverse every string.
        {
            var words = str.Split(" ");
            List<string> strList = new List<string>();
            string result = "";
            foreach (var item in words)
            {
                var x = item.ToCharArray();
                Array.Reverse(x);
                strList.Add(new string(x));
            }
            for (int i = 0; i < strList.Count; i++)
            {
                result+= strList[i].ToString();
                if (i < strList.Count)
                {
                    result += " ";
                }
            }
            return result;
        }

        public static string ReverseSentence(string str) //Bad -> I need to reverse every string.
        {
            List<char> words = new List<char>();

            for (int i = str.Length-1 ; i >= 0; i--)
            {
                words.Add(str[i]);
            }
            return new string(words.ToArray());
        }

        public static string ReverseWordsLinq(string str) => string.Join(" ", str.Split().Select(x => string.Concat(x.Reverse())));
    }
}
