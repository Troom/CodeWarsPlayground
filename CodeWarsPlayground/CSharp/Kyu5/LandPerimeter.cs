namespace CodeWarsPlayground.CSharp.Kyu5
{
    internal static class LandPerimeter
    {
        public static string Calculate(string[] map)
        {
            string resultMsg = "Total land perimeter: ";
            int counter = 0;
            if (map == null || map.Length == 0 || !map.Any(x => x.Contains("X")))
                return resultMsg + "0";

            if (map.Length == 1 && map.FirstOrDefault() == "X")
                return resultMsg + "4";

            for (int i = 0; i < map.Length; i++)
            {
                for (int j = 0; j < map[i].Length; j++)
                {
                    if (map[i][j] == 'X')
                    {
                        if (i == 0 || map[i - 1][j] == 'O')
                            counter++;
                        if (j == 0 || map[i][j - 1] == 'O')
                            counter++;
                        if (j == map[i].Length - 1 || map[i][j + 1] == 'O')
                            counter++;
                        if (i == map.Length - 1 || map[i + 1][j] == 'O')
                            counter++;
                    }
                }
            }
            return resultMsg + counter;
        }

    }
}
