namespace CodeWarsPlayground.CSharp.Kyu7
{
    public class Isograms
    {
        public static bool IsIsogram(string str)
        {
            str = str.ToLower();
            HashSet<char> seen = new HashSet<char>();
            foreach (char ch in str)
            {
                if (seen.Contains(ch))
                    return false;
                seen.Add(ch);
            }
            return true;
        }
    }
}
