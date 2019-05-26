using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    class UniversalSort
    {
        public static void Sort(ref List<int> _list) {

            bool isSorted;
            do
            {
                isSorted = true;
                for (int i = 0; i < _list.Count - 1; i++)
                {
                    if (_list[i] < _list[i + 1])
                    {
                        int tmp = _list[i];
                        _list[i] = _list[i + 1];
                        _list[i + 1] = tmp;
                        isSorted = false;
                    }
                }
            } while (!isSorted);
        }
    }
}
