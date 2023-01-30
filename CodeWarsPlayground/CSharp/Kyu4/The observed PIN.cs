namespace CodeWarsPlayground.CSharp.Kyu4
{
    internal static class The_observed_PIN
    {
        public static List<string> GetPINs(string observed)
        {
            if (observed.Length == 0)
            {
                return new List<string>();
            }
            List<string> lista = new List<string>();

            lista = FirstGetPin(lista, observed[0]);

            if (observed.Length > 1)
            {
                for (int i = 1; i < observed.Length; i++)
                {
                    lista = GetPinMethod(lista, observed[i]);
                }
            }
            return lista;
        }

        private static List<string> FirstGetPin(List<string> lista, char v)
        {
            switch (v)
            {
                case '0':
                    lista.Add("0");
                    lista.Add("8");
                    break;

                case '1':
                    lista.Add("1");
                    lista.Add("2");
                    lista.Add("4");
                    break;

                case '2':
                    lista.Add("1");
                    lista.Add("2");
                    lista.Add("3");
                    lista.Add("5");
                    break;

                case '3':
                    lista.Add("2");
                    lista.Add("3");
                    lista.Add("6");

                    break;

                case '4':
                    lista.Add("1");
                    lista.Add("4");
                    lista.Add("5");
                    lista.Add("7");

                    break;

                case '5':
                    lista.Add("2");
                    lista.Add("4");
                    lista.Add("5");
                    lista.Add("6");
                    lista.Add("8");
                    break;

                case '6':
                    lista.Add("3");
                    lista.Add("5");
                    lista.Add("6");
                    lista.Add("9");
                    break;

                case '7':
                    lista.Add("4");
                    lista.Add("7");
                    lista.Add("8");
                    break;

                case '8':
                    lista.Add("8");
                    lista.Add("0");
                    lista.Add("7");
                    lista.Add("9");
                    lista.Add("5");
                    break;

                case '9':
                    lista.Add("6");
                    lista.Add("8");
                    lista.Add("9");
                    break;

                default:
                    break;
            }

            return lista;
        }

        private static List<string> GetPinMethod(List<string> lista, char v)
        {
            int counter = lista.Count;
            var newList = lista.ToList();
            lista.Clear();

            for (int i = 0; i < counter; i++)
            {
                switch (v)
                {
                    case '0':
                        lista.Add(newList[i] + "0");
                        lista.Add(newList[i] + "8");
                        break;

                    case '1':
                        lista.Add(newList[i] + "1");
                        lista.Add(newList[i] + "2");
                        lista.Add(newList[i] + "4");
                        break;

                    case '2':
                        lista.Add(newList[i] + "1");
                        lista.Add(newList[i] + "2");
                        lista.Add(newList[i] + "3");
                        lista.Add(newList[i] + "5");
                        break;

                    case '3':
                        lista.Add(newList[i] + "2");
                        lista.Add(newList[i] + "3");
                        lista.Add(newList[i] + "6");

                        break;

                    case '4':
                        lista.Add(newList[i] + "1");
                        lista.Add(newList[i] + "4");
                        lista.Add(newList[i] + "5");
                        lista.Add(newList[i] + "7");

                        break;

                    case '5':
                        lista.Add(newList[i] + "2");
                        lista.Add(newList[i] + "4");
                        lista.Add(newList[i] + "5");
                        lista.Add(newList[i] + "6");
                        lista.Add(newList[i] + "8");
                        break;

                    case '6':
                        lista.Add(newList[i] + "3");
                        lista.Add(newList[i] + "5");
                        lista.Add(newList[i] + "6");
                        lista.Add(newList[i] + "9");

                        break;

                    case '7':
                        lista.Add(newList[i] + "4");
                        lista.Add(newList[i] + "7");
                        lista.Add(newList[i] + "8");

                        break;

                    case '8':
                        lista.Add(newList[i] + "8");
                        lista.Add(newList[i] + "0");
                        lista.Add(newList[i] + "7");
                        lista.Add(newList[i] + "9");
                        lista.Add(newList[i] + "5");
                        break;

                    case '9':
                        lista.Add(newList[i] + "6");
                        lista.Add(newList[i] + "8");
                        lista.Add(newList[i] + "9");
                        break;

                    default:
                        break;
                }
            }
            return lista;
        }
    }
}