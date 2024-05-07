namespace CodeWarsPlayground.CSharp.Kyu8
{
    public static class Fundamentals_Return
    {
        public static int Add(int a, int b) => a + b;
        public static int Multiply(int a, int b) => a * b;
        public static int Divide(int a, int b) => a / b;
        public static int Mod(int a, int b) => a % b;
        public static int Exponent(int a, int b) => IntPow(a, b);
        public static int Subt(int a, int b) => a - b;

        public static int IntPow(int x, int pow)
        {
            int ret = 1;
            while (pow != 0)
            {
                if ((pow & 1) == 1)
                    ret *= x;
                x *= x;
                pow >>= 1;
            }
            return ret;
        }
    }
}