namespace CodeWarsPlayground.CSharp.Kyu8
{
    internal static class Price_of_Mangoes
    {
        public static int Mango(int quantity, int price) => quantity / 3 > 0 ? (quantity - (quantity / 3)) * price : quantity * price;
    }
}
