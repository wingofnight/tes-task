using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuest2
{
    public static class Converter
    {
        public static LinkedList<int> ConvertFloatToInt(LinkedList<float> floatList)
        {
            LinkedList<int> intList = new LinkedList<int>();

            if (floatList!=null)
            {
                foreach (float item in floatList)
                {
                    intList.AddLast(Convert.ToInt32(item));
                }
                return intList;
            }
            else { return null; }
            
        }
    }
}
