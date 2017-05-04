using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    class Sandbox
    {
        public Sandbox()
        { }

        public List<int> UnionSortedLists(List<int> firstSortedList, List<int> secondSortedList)
        {
            var unionedList = new List<int>();

            unionedList.Add(firstSortedList[0]);
            unionedList.Add(secondSortedList[0]);

            return unionedList;
        }
    }
}
