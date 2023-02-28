namespace CodeWarsPlayground.CSharp.Kyu4
{
    internal class StringsMix
    {

        public static string Mix(string s1, string s2)
        {
            var s1List = GenerateList(s1);
            var s2List = GenerateList(s2);

            RemoveTooSmallValue(s1List);
            RemoveTooSmallValue(s2List);

            var UnionKeys = s1List.Keys.Union(s2List.Keys).ToList();

            var ItemList = GenerateFinalList(s1List, s2List, UnionKeys);

            var result = GenerateOutput(ItemList);
            return result.TrimEnd('/');
        }

        private static string GenerateOutput(List<Tuple<char, char, int>> final)
        {
            string result = "";

            foreach (var item in final)
            {
                switch (item.Item1)
                {
                    case '1':
                        result += "1:" + new string(item.Item2, item.Item3) + "/";
                        break;
                    case '2':
                        result += "2:" + new string(item.Item2, item.Item3) + "/";
                        break;
                    case '3':
                        result += "=:" + new string(item.Item2, item.Item3) + "/";

                        break;
                    default:
                        throw new ArgumentException();
                }
            }
            return result;
        }

        private static List<Tuple<char, char, int>> GenerateFinalList(Dictionary<char, int> s1List, Dictionary<char, int> s2List, List<char> UnionKeys)
        {
            var itemList = new List<Tuple<char, char, int>>();

            foreach (var item in UnionKeys)
            {
                int value1 = s1List.TryGetValue(item, out value1) ? value1 : 0;
                int value2 = s2List.TryGetValue(item, out value2) ? value2 : 0;

                if (value1 > value2)
                {
                    itemList.Add(new Tuple<char, char, int>('1', item, value1));
                    continue;
                }
                if (value1 < value2)
                {
                    itemList.Add(new Tuple<char, char, int>('2', item, value2));
                    continue;
                }

                if (value2 == s2List[item])
                    itemList.Add(new Tuple<char, char, int>('3', item, value1));
            }
            return itemList.OrderByDescending(x => x.Item3).ThenBy(x => x.Item1).ThenBy(x => x.Item2).ToList();
        }

        private static void RemoveTooSmallValue(Dictionary<char, int> dictionary)
        {
            foreach (var item in dictionary)
            {
                if (item.Value < 2)
                    dictionary.Remove(item.Key);
            }
        }

        private static Dictionary<char, int> GenerateList(string str)
        {
            var tmpList = new Dictionary<char, int>();

            foreach (var item in str)
            {
                if (char.IsLower(item))
                {
                    if (tmpList.ContainsKey(item))
                        tmpList[item]++;
                    else
                        tmpList.Add(item, 1);
                }
            }
            return tmpList.OrderByDescending(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

        //##
        public static string MixLinq(string s1, string s2)
        {
            var s1Group = s1.Where(c => char.IsLower(c) && char.IsLetter(c)).GroupBy(a => a, b => b).Select(a => new { letter = a.Key, count = a.Count() });

            var s2Group = s2.Where(c => char.IsLower(c) && char.IsLetter(c)).GroupBy(a => a, b => b).Select(a => new { letter = a.Key, count = a.Count() });

            var s12Group = s1Group.Concat(s2Group).GroupBy(a => a.letter, b => b);

            var sGrouped = s12Group.Select(a => new {
                count = a.OrderByDescending((p => p.count)).First().count,
                letter = a.Key,
                winner = s1.Count(i => i == a.Key) > s2.Count(i => i == a.Key)
                                                ? "1" : s1.Count(i => i == a.Key) < s2.Count(i => i == a.Key) ? "2" : "="
            });

            return string.Join("/", sGrouped.Where(o => o.count > 1).OrderByDescending(o => o.count)
            .ThenBy(o => int.Parse(o.winner == "=" ? "3" : o.winner))
            .ThenBy(o => o.letter).Select(gz => gz.winner + ":" + new string(gz.letter, gz.count)));
        }

    }
}
