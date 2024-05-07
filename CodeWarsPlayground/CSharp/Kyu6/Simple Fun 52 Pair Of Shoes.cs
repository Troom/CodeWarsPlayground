namespace CodeWarsPlayground.CSharp.Kyu6
{
    internal class Simple_Fun_52_Pair_Of_Shoes
    {


        public bool PairOfShoes(int[][] shoes)
        {
            int tmpCount;
            do
            {
                tmpCount = shoes.Length;
                shoes = LookForPair(shoes.ToList());
                if (shoes.Length == tmpCount)
                {
                    return false;
                }
            } while (shoes.Length > 0);

            return true;
        }

        private int[][] LookForPair(List<int[]> shoes)
        {
            var tmp = shoes.FirstOrDefault();
                if (shoes.Any(x => x[1] == tmp[1] && x[0] != tmp[0]))
                {
                    var tmpp = shoes.Find(x => x[0] == 0 && x[1] == tmp[1]);
                    shoes.Remove(tmpp);
                    tmpp = shoes.Find(x => x[0] == 1 && x[1] == tmp[1]);
                    shoes.Remove(tmpp);
                }
            return shoes.ToArray();
        }


        public bool PairOfShoesShort(int[][] shoes) => shoes.GroupBy(x => x[1]).All(x => x.Count(y => y[0] == 0) == x.Count(y => y[0] == 1));

        public bool PairOfShoesOther(int[][] shoes) => shoes
                    .GroupBy(x => x[1])
                    .Select(gr => new
                    {
                        Rights = gr.Count(x => x[0] == 0),
                        Lefts = gr.Count(x => x[0] == 1)
                    })
                    .All(x => x.Rights == x.Lefts);
                    }
}
