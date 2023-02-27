namespace CodeWarsPlayground.CSharp.Kyu5
{
    internal class GreedIsGood {
        public static int Score(int[] dice)
        {
            var dict = new Dictionary<int, int>();
            int result = 0;

            foreach (var item in dice)
            {
                if (dict.ContainsKey(item))
                    dict[item]++;
                else
                    dict.Add(item, 1);
            }

            foreach (var item in dict)
            {
                if (item.Key == 1 && item.Value %3 != 0)
                    result += 100 * (item.Value % 3);
                
                if (item.Key == 5 && item.Value % 3 != 0)
                    result += 50 * (item.Value % 3);
                
                if (item.Value/3 >0)
                    result += CalculateScore(item.Key, item.Value/3);
            }
            return result;
        }

        private static int CalculateScore(int key, int value)
        {
            switch (key)
            {
                case 1: 
                    return 1000 * value;
                case 2:
                    return 200 * value;
                case 3:
                    return 300 * value;
                case 4:
                    return 400 * value;
                case 5:
                    return 500 * value;
                case 6:
                    return 600 * value;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        //##
        public static int ScoreClever(int[] dice)
        {
            int[] tripleValue = { 0, 1000, 200, 300, 400, 500, 600 };
            int[] singleValue = { 0, 100, 0, 0, 0, 50, 0 };

            int value = 0;
            for (int dieSide = 1; dieSide <= 6; dieSide++)
            {
                int countRolls = dice.Where(outcome => outcome == dieSide).Count();
                value += tripleValue[dieSide] * (countRolls / 3) + singleValue[dieSide] * (countRolls % 3);
            }
            return value;
        }
        //##

        public static int ScoreLinq(int[] dice)
        {
            return dice
              .GroupBy(d => d)
              .Select(g => Points(g.Key, g.Count()))
              .Sum();
        }

        private static int Points(int die, int count)
        {
            switch (die)
            {
                case 1:
                    return (count / 3) * 1000 + (count % 3) * 100;
                case 5:
                    return (count / 3) * 500 + (count % 3) * 50;
                default:
                    return (count / 3) * die * 100;
            }
        }


    }
}


