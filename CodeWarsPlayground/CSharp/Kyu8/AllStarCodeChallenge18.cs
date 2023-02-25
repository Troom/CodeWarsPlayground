namespace CodeWarsPlayground.CSharp.Kyu8
{
    internal class AllStarCodeChallenge18
    {
        public static int StrCount(string str, char letter)
        {
            int counter = 0;
            foreach (var item in str) {
                if (item == letter)
                    counter++;
            }
            return counter;
        }

    }
}
