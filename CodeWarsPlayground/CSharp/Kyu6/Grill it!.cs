namespace CodeWarsPlayground.CSharp.Kyu6
{
    internal class Grill_it_
    {

        public static string Grille(string message, int code)
        {
            string binaryCode = Convert.ToString(code, 2).PadLeft(message.Length, '0');
            string decryptedMessage = "";
            if (message.Length < binaryCode.Length)
                binaryCode = binaryCode.Substring(binaryCode.Length - message.Length);
            for (int i = 0; i < message.Length; i++)
            {
                if (binaryCode[i] == '1')
                {
                    decryptedMessage += message[i];
                }
            }
            return decryptedMessage;
        }
        public static string Grille1(string message, int code)
        {
            string mapper = (mapper = new string('0', message.Length) + Convert.ToString(code, 2)).Substring(mapper.Length - message.Length);
            return string.Concat(message.Where((e, i) => mapper[i] == '1'));
        }

        public static string GrilleLinq(string m, int code) =>
            String.Concat(m.Where((c, i) => ((long)1 << m.Length - i - 1 & code) != 0));
    }
}