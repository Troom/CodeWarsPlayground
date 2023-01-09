namespace CodeWarsPlayground.CSharp.Kyu6
{
    public static class HighestScoringWord
    {
        public static string High(string s)
        {
            var x = s.Split(" ");
            string result = "";
            int resultWordValue = 0;
            for (int i = 0; i < x.Length; i++)
            {
                var currentWordValue = 0;
                for (int j = 0; j < x[i].Length; j++)
                {
                    currentWordValue += (int)x[i][j] - 96;
                }
                if (currentWordValue > resultWordValue)
                {
                    resultWordValue = currentWordValue;
                    result = x[i];
                }
            }
            return result;
        }

        public static string HighLinq(string s) //worst performance
        {
            return s.Split(' ').OrderBy(a => a.Select(b => b - 96).Sum()).Last();
        }



    }
}
