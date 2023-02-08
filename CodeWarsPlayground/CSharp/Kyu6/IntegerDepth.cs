namespace CodeWarsPlayground.CSharp.Kyu6
{
    internal class IntegerDepth
    {
        public static int ComputeDepth(int n)
        {
            var digitsLeft = new HashSet<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int result = 0;
            string tmpString;
            do
            {
                result++;
                tmpString = (n * result).ToString();
                foreach (var item in tmpString)
                {
                    digitsLeft.Remove(item);
                }
            } while (digitsLeft.Count > 0);

            return result;
        }
        //HashSet are faster than list. In my tests are better about 30%. 
        //For more informations please read this SO Question
        //https://stackoverflow.com/questions/150750/hashset-vs-list-performance


    }
}
