namespace CodeWarsPlayground.CSharp.Kyu8
{
    public class Multiply_the_number
    {
        public static int Multiply(int number) => number * ((int)Math.Pow(5, Math.Floor(Math.Log10(Math.Abs(number)) + 1)));
    }
}
