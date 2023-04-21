namespace CodeWarsPlayground.CSharp.Kyu7
{
    internal static class SumAListButIgnoreAnyDuplicates
    {

        public static int SumNoDuplicatesOneLiner(int[] arr) => arr.Sum(x => arr.Count(i => i == x) == 1 ? x : 0);

        public static int SumNoDuplicatesDictionary(int[] arr)
        {
            var dic = new Dictionary<int, int>();

            foreach (var i in arr)
            {
                if (dic.ContainsKey(i))
                    dic[i]++;
                else
                    dic.Add(i, 1);
            }

            List<int> list = new List<int>();

            foreach (var item in dic)
            {
                if (item.Value == 1)
                    list.Add(item.Key);
            }

            return list.Sum();
        }
    }
}
