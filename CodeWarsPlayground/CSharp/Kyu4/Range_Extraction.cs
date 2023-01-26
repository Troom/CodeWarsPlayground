using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsPlayground.CSharp.Kyu4
{
    internal class Range_Extraction
    {
        public static string Extract(int[] args)
        {
            if (args.Length == 2)
                return args[0] + "," + args[1];

            string result = "";
            List<int> range = new List<int>(); 

            for (int i = 0; i < args.Length; i++)
            {
                if (i+1 == args.Length)
                {
                    range.Add(args[i]);
                    if (range.Count == 1)
                        result += range.First();
                    if (range.Count == 2)
                        result += range.First() + "," + range.Last();
                    if (range.Count > 2)
                        result += range.First().ToString() + "-" + range.Last();
                    continue;
                }
                if (args[i]+1 == args[i+1])
                    range.Add(args[i]);

                if (args[i] + 1 != args[i + 1] && range.Count ==0)
                    result += args[i] + ",";

                if (args[i] + 1 != args[i + 1] && range.Count> 0)
                {
                    range.Add(args[i]);
                    if (range.Count == 2)
                    {
                        foreach (var item in range)
                            result += item + ",";
                        range.Clear();
                    }
                    if (range.Count > 2)
                    {
                        result += range.First().ToString() + "-" + range.Last().ToString() + ",";
                        range.Clear();
                    }
                }
            }
            return result;
        }





        public class RangeExtractionClass
        {
            public int Value, Count;
            public int NextValue => Value + Count;

            public RangeExtractionClass(int value)
            {
                Value = value;
                Count = 1;
            }

            public override string ToString()
                => Count == 1 ? $"{Value}" :
                   Count == 2 ? $"{Value},{Value + 1}" :
                                $"{Value}-{NextValue - 1}";

            public static string Extract(int[] args)
            {
                var list = new List<RangeExtractionClass>();

                foreach (var n in args)
                    if (list.LastOrDefault()?.NextValue == n) list.Last().Count++;
                    else list.Add(new RangeExtractionClass(n));

                return string.Join(",", list);
            }
        }


        public static string ExtractSmall(int[] args)
        {
            var result = "";

            for (var i = 0; i < args.Length; i++)
            {
                var seq = new List<int> { args[i] };

                while (i < args.Length - 1 && args[i + 1] == args[i] + 1)
                    seq.Add(args[++i]);

                if (seq.Count < 3)
                    result = seq.Aggregate(result, (s, n) => s + (n + ","));
                else
                    result += seq[0] + "-" + seq[^1] + ",";
            }

            return result.TrimEnd(',');
        }
    }
}
