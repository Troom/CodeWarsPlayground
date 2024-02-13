namespace CodeWarsPlayground.CSharp.Kyu6
{
    internal class Split_and_then_add_both_sides_of_an_array_together
    {
        public static int[] SplitAndAdd(int[] numbers, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int mid = numbers.Length / 2;
                var arr1 = numbers.Take(mid).ToArray();
                var arr2 = numbers.Skip(mid).ToArray();
                if (arr2.Length > arr1.Length)
                {
                    var tmpArr = new int[] { 0 };
                    arr1 = tmpArr.Concat(arr1).ToArray();
                    //Alternative way  var arr1 = arr1.Prepend(0).ToArray();
                }

                numbers = new int[Math.Max(arr1.Length, arr2.Length)];
                for (int j = 0; j < numbers.Length; j++)
                {
                    numbers[j] = (j < arr1.Length ? arr1[j] : 0) + (j < arr2.Length ? arr2[j] : 0);
                }
            }
            return numbers;
        }
    }
}
