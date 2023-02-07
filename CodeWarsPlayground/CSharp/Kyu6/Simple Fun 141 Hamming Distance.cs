namespace CodeWarsPlayground.CSharp.Kyu6
{
    internal class Simple_Fun_141_Hamming_Distance
    {
        public int HammingDistance(int a, int b)
        {
            var aBinary = Convert.ToString(a, 2);
            var bBinary = Convert.ToString(b, 2);
            int result = 0;
            if (aBinary.Length != bBinary.Length)
            {
                int lengthDiffrence = aBinary.Length - bBinary.Length;
                if (lengthDiffrence < 0)
                {
                    do
                    {
                        aBinary = "0" + aBinary;
                        lengthDiffrence++;
                    } while (lengthDiffrence < 0);   
                }
                if (lengthDiffrence > 0)
                {
                    do
                    {
                        bBinary = "0" + bBinary;
                        lengthDiffrence--;
                    } while (lengthDiffrence > 0);
                }
            }

            for (int i = 0; i < aBinary.Length; i++)
            {
                if (aBinary[i] != bBinary[i])
                {
                    result++;
                }
            }
            return result;
        }


        public int HammingDistanceCount(int a, int b)
        {
            return Convert.ToString(a ^ b, 2).Count(x => x == '1');
        }


        public int HammingDistanceBits(int a, int b) => CountBits(a ^ b);
        private int CountBits(int x, int bits = 0) => x == 0 ? bits : CountBits(x & (x - 1), 1 + bits);
    }
}
