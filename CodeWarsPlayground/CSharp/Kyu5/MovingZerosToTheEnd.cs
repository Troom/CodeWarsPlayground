namespace CodeWarsPlayground.CSharp.Kyu5
{
    public static  class MovingZerosToTheEnd
    {
        public static int[] MoveZeroes(int[] arr)
        {
            var result = new List<int>();
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    counter++;
                }
                else
                {
                    result.Add(arr[i]);
                }
            }
            for (int i = 0; i < counter; i++)
            {
                result.Add(0);
            }
            return result.ToArray();
        }

        public static int[] MoveZeroesOrderBy(int[] arr) => arr.OrderBy(x => x == 0).ToArray();
    }
}
