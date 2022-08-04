using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuest2
{
    public static class FirstApp
    {
        public static float AdditionModule(float[] numbers)
        {
            float sum = 0;
            float counter = 0;
            foreach (var item in numbers)
            {
                if (item % 2 != 0)
                {
                    counter++;
                    if (counter % 2 == 0)
                    {
                        sum += item;
                    }
                }
            }
            return Math.Abs(sum);
        }
    }
}
