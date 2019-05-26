using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { -1, 10, 3, 99, 500, 0, 20 };

            UniversalSort.Sort(ref list);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
