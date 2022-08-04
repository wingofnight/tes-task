using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TestQuest2
{
    //Данный класс, метод, разбирает строку
    public static class Separator
    {
        
        public static float[] SeparatorArray(string ArrayWithString)
        {
            string[]str = ArrayWithString.Split(',');
            float[] array = new float[str.Length];
            int counter = 0;
            foreach (var item in str)
            {
                item.Trim(' ');

                try
                {   // Эта строка добавляет в массив числа, предворительно проверив их на "точку" (десятичные и тд.).
                    // Не всегда точка из строки правильно парсится, поэтому надо явно указать, что это разделитель.
                    array[counter] = float.Parse(item.Replace(".", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator),
                    CultureInfo.InvariantCulture);
                    counter++;
                }
                catch (Exception)
                {   //Если пользователь будет хитрить.
                    return null;                    
                }
            }
            return array;
        }

        public static LinkedList<float> SeparatorLinkedList(string ArrayWithString)
        {
            string[] str = ArrayWithString.Split(',');
            LinkedList<float> array = new LinkedList<float>();
           
            foreach (var item in str)
            {
                item.Trim(' ');

                try
                {   // Эта строка добавляет в массив числа, предворительно проверив их на "точку" (десятичные и тд.).
                    // Не всегда точка из строки правильно парсится, поэтому надо явно указать, что это разделитель.
                    array.AddLast( float.Parse(item.Replace(".", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator),
                    CultureInfo.InvariantCulture));
                }
                catch (Exception)
                {   //Если пользователь будет хитрить.
                    return null;
                }
            }
            return array;
        }
    }
}
