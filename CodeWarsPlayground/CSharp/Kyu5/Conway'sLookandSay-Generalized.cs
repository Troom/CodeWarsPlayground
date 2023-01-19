using System.Text;

namespace CodeWarsPlayground.CSharp.Kyu5
{
    internal class Conway_sLookandSay_Generalized
    {
        public static ulong LookSay(ulong number)
        {
            var numberString = number.ToString();
            int counter = 1;
            StringBuilder stringBuilder = new StringBuilder(); //only for large long value. In other case simple string concatenation is better
            for (int i = 0; i < numberString.Length; i++)
            {
                if (i == numberString.Length-1)
                {
                    stringBuilder.Append(counter);
                    stringBuilder.Append(numberString[i]);
                    break;
                }

                if (numberString[i] != numberString[i+1])
                {
                    stringBuilder.Append(counter);
                    stringBuilder.Append(numberString[i]);
                    counter = 1;
                }
                else
                    counter++;
            }
            return (ulong)Convert.ToDouble(stringBuilder.ToString());

        }




        public static ulong LookSayForEveryLetter(ulong number)
        {
            var x = number.ToString().GroupBy(x => x).Select(x => new { letter = x.Key, count = x.Count() });
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in x)
            {
                stringBuilder.Append(item.count);
                stringBuilder.Append(item.letter);
            }
            return (ulong)Convert.ToDouble(stringBuilder.ToString());
        }

    }
}
