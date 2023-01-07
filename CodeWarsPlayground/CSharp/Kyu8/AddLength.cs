namespace CodeWarsPlayground.CSharp.Kyu8
{
    public class AddLengthClass
    {

        public static string[] AddLength(string str)
        {
            var x = str.Split(" ");
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = x[i] + " " + x[i].Count().ToString();
            }
            return x;
        }


    }
}
