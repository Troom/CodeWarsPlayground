namespace CodeWarsPlayground.CSharp.Kyu7
{
    internal class AnotherCardGame
    {
        public static bool Game(int[] frank, int[] sam, int[] tom)
        {
            int result = 0;
            var frankList = frank.ToList();
            int samCard;
            int tomCard;
            if (frankList[0] == 0)
            {
                samCard = sam[sam.Length-1];
                tomCard = tom[tom.Length-1];
            }
            for (int i = 0; i < frankList.Count; i++)
            {
                int tmp = 0;
                samCard = sam[i];
                tomCard = tom[i];
                tmp = frankList.Where(x => x > samCard && x > tomCard).FirstOrDefault();
                frankList.Remove(tmp);
                if (tmp >0)
                    result++;
            }
            return result > 1;
        }
    }
}
