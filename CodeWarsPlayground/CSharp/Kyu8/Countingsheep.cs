namespace CodeWarsPlayground.CSharp.Kyu8
{
    internal class Countingsheep
    {
        public static int CountSheeps(bool[] sheeps) => sheeps.Where(x=> x == true).Count();
    }
}
