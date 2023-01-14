using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsPlayground.CSharp.Kyu6
{
    internal static class FindTheUniqueNumber
    {
        public static int GetUniqueLinq(IEnumerable<int> numbers) => numbers.GroupBy(x=>x).Where(y=>y.Count() == 1).Select(z=>z.Key).FirstOrDefault();

    }
}
