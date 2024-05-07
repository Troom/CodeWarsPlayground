using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsPlayground.CSharp.Kyu7
{
    public static class ComplementaryDNA
    {
        public static string MakeComplement(string dna)
        {
            var sb = new StringBuilder();
            foreach (char c in dna)
            {
                switch (c)
                {
                    case 'A':
                    {
                        sb.Append('T');
                        break;
                    }
                    case 'T':
                    {
                        sb.Append('A');
                        break;
                    }
                    case 'G':
                    {
                        sb.Append('C');
                        break;
                    }
                    case 'C':
                    {
                        sb.Append('C');
                        break;
                    }
                }
            }
            return sb.ToString();
        }
    }
}
