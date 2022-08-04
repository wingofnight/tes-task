using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuest2
{
    public static class SecondApp
    {
        public static LinkedList<int> SumTwoLists(LinkedList<int> firstList, LinkedList<int> secondList)
        {
            var item1 = firstList.First;
            var item2 = secondList.First;

            if (firstList.Count > secondList.Count) return Sum(item1, item2);
            else return Sum(item2, item1);
        }

        private static LinkedList<int> Sum(LinkedListNode<int> firstList, LinkedListNode<int> secondList)
        {
            var resultList = new LinkedList<int>();
            int overflow = 0;

            while (firstList != null)
            {
                if (secondList != null)
                {
                    resultList.AddLast((firstList.Value + firstList.Value + overflow) % 10);
                    overflow = (firstList.Value + secondList.Value + overflow) / 10;
                    firstList = firstList.Next;
                    secondList = secondList.Next;
                    if (firstList == null && overflow == 1) resultList.AddLast(overflow);
                }
                else
                {
                    resultList.AddLast((firstList.Value + overflow) % 10);
                    overflow = (firstList.Value + overflow) / 10;
                    firstList = firstList.Next;
                }
            }
            return resultList;
        }
    }
}
