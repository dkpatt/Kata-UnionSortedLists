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
            
            int position1 = 0;
            int position2 = 0;

            do
            {
                if (position1 == firstSortedList.Count)
                {
                    unionedList.Add(secondSortedList[position2]);

                    if (position2 < secondSortedList.Count)
                    {
                        position2++;
                    }
                }
                else if (position2 == secondSortedList.Count)
                {
                    unionedList.Add(firstSortedList[position1]);

                    if (position1 < firstSortedList.Count)
                    {
                        position1++;
                    }
                }
                else if (firstSortedList[position1] < secondSortedList[position2])
                {
                    unionedList.Add(firstSortedList[position1]);

                    if (position1 < firstSortedList.Count)
                    {
                        position1++;
                    }
                }
                else if (firstSortedList[position1] == secondSortedList[position2])
                {
                    unionedList.Add(firstSortedList[position1]);

                    if (position1 < firstSortedList.Count)
                    {
                        position1++;
                    }
                    if (position2 < secondSortedList.Count)
                    {
                        position2++;
                    }
                }
                else if (firstSortedList[position1] > secondSortedList[position2])
                {
                    unionedList.Add(secondSortedList[position2]);

                    if (position2 < secondSortedList.Count)
                    {
                        position2++;
                    }
                }
            } while (position1 < firstSortedList.Count || position2 < secondSortedList.Count);
            
            return unionedList;
        }
    }
}
