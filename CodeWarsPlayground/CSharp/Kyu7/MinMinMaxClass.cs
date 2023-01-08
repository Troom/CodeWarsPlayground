namespace CodeWarsPlayground.CSharp.Kyu7
{
    public class MinMinMaxClass
    {
        public static int[] MinMinMax(int[] array)
        {
            var result = new List<int>
            {
                array.Min()
            };
            for (int i = 0; i < array.Length; i++)
            {
                if (!array.Contains(result.FirstOrDefault() + i))
                {
                    result.Add(result.FirstOrDefault() + i);
                    break;
                }
            }
            result.Add(array.Max());
            return result.ToArray();
        }
        public static int[] MinMinMax1(int[] array)
        {
            int smallest = array.Min();
            int largest = array.Max();
            for (int i = smallest + 1; i < largest; i++)
                if (!array.Contains(i)) return new int[] { smallest, i, largest };
            return new int[] { };
        }
        public static int[] MinMinMax2(int[] a) => new[] { a.Min(), Enumerable.Range(a.Min(), a.Max()).Except(a).First(), a.Max() };

    }
}
