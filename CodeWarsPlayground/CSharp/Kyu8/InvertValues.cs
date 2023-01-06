namespace CodeWarsPlayground.CSharp.Kyu8
{
    public static class InvertValuesClass
    {
        //#Arrays #Enumerable
        public static int[] InvertValues(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i] * -1;
            }
            return input;
        }
    }
}
