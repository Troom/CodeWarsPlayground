namespace CodeWarsPlayground.CSharp.Kyu7
{
    public static class CategorizeNewMember
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            var result = new List<string>();
            foreach (var item in data)
            {
                if (item[0] >= 55)
                {
                    if (item[1] > 7)
                    {
                        result.Add("Senior");
                        continue;
                    }
                }
                result.Add("Open");
            }
            return result;
        }

        public static IEnumerable<string> OpenOrSeniorSelect(int[][] data) =>
                 data.Select(member => member[0] >= 55 && member[1] > 7 ? "Senior" : "Open").ToList();
    }   
}
