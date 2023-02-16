namespace CodeWarsPlayground.CSharp.Kyu4
{
    internal class SumOfIntervals
    {
        //https://www.codewars.com/kata/52b7ed099cdc285c300001cd/train/csharp
        public static int SumIntervals((int, int)[] intervals)
        {
            if (intervals.Count() == 0)
                return 0;

            if (intervals.Count() == 1)
                return intervals.FirstOrDefault().Item2 - intervals.FirstOrDefault().Item1;

            intervals = intervals.OrderBy(x => x.Item1).ToArray();

            List<ValueTuple<int,int>> merged = new List<ValueTuple<int, int>> () { (intervals.FirstOrDefault().Item1, intervals.FirstOrDefault().Item2) };

            for (int i = 0; i < intervals.Count(); i++)
            {
                if (intervals[i].Item1 <= merged.LastOrDefault().Item2)
                    if (intervals[i].Item2 >= merged.LastOrDefault().Item2)
                        merged[merged.Count-1] = new ValueTuple<int, int>(merged[merged.Count-1].Item1, intervals[i].Item2);
                    else
                        continue;
                else
                    merged.Add(intervals[i]);
            }
            
            int result = 0;

            foreach (var item in merged)
                result += item.Item2 - item.Item1;
            
            return result;
        }
    }
}
