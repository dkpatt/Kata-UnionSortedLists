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
            
            int pointer1 = 0;
            int pointer2 = 0;

            do
            {
                if (pointer1 == firstSortedList.Count)
                {
                    unionedList.Add(secondSortedList[pointer2]);

                    pointer2 = this.AdvancePointer(pointer2, secondSortedList);
                }
                else if (pointer2 == secondSortedList.Count)
                {
                    unionedList.Add(firstSortedList[pointer1]);

                    pointer1 = this.AdvancePointer(pointer1, firstSortedList);
                }
                else if (firstSortedList[pointer1] < secondSortedList[pointer2])
                {
                    unionedList.Add(firstSortedList[pointer1]);

                    pointer1 = this.AdvancePointer(pointer1, firstSortedList);
                }
                else if (firstSortedList[pointer1] == secondSortedList[pointer2])
                {
                    unionedList.Add(firstSortedList[pointer1]);

                    pointer1 = this.AdvancePointer(pointer1, firstSortedList);
                    pointer2 = this.AdvancePointer(pointer2, secondSortedList);
                }
                else if (firstSortedList[pointer1] > secondSortedList[pointer2])
                {
                    unionedList.Add(secondSortedList[pointer2]);

                    pointer2 = this.AdvancePointer(pointer2, secondSortedList);                    
                }
            } while (pointer1 < firstSortedList.Count || pointer2 < secondSortedList.Count);
            
            return unionedList;
        }

        private int AdvancePointer( int pointer, List<int> listForPointer)
        {
            if(pointer < listForPointer.Count)
            {
                pointer++;
            }

            return pointer;
        }
    }
}
