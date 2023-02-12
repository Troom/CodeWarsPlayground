using System.Text;

namespace CodeWarsPlayground.CSharp.Kyu7
{
    internal static class StringAddiitionNeedHighSpeed
    {
        public static string Performance(Func<int> method)
        {
            //StringBuilder is great for large numbers of concatenations
            StringBuilder sb = new StringBuilder(); 

            for (int i = 0; i < 150000; i++)
            {
                sb.Append(method.Invoke());
            }
            return sb.ToString();
        }
    }
}
