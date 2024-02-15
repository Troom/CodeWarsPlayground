namespace CodeWarsPlayground.CSharp.Kyu8
{
    internal class Sum_without_highest_and_lowest_number
    {

        public static int Sum(int[] numbers)
        {
            if (numbers is null)
                return 0;
            if (numbers.Length < 2)
                return 0;

            return numbers.Sum() - (numbers.Min() + numbers.Max());
        }

    }
}
