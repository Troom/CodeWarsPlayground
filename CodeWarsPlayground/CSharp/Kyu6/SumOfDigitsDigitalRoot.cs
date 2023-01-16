namespace CodeWarsPlayground.CSharp.Kyu6
{
    internal class SumOfDigitsDigitalRoot
    {
        public string SumOfDigits(long x)
        {
            int result = 0;
            foreach (var item in x.ToString())
            {
                result += Convert.ToInt32(item) - 48;
            }
            return result.ToString();
        }

        public int DigitalRoot(long n)
        {
            var result = n.ToString();

            while (result.Length > 1)
            {
                result = SumOfDigits(Convert.ToInt64(result));
            }
            return Convert.ToInt32(result);
        }


        public int DigitalRootSmart(long n) //Much better performance
        {
            return (int)(1 + (n - 1) % 9);
        }


        public int DigitalRoot2(long n)
        {
            if (n < 10) return (int)n;
            long r = 0;
            while (n > 0)
            {
                r += n % 10;
                n /= 10;
            }
            return DigitalRoot2(r);
        }

    }
}
