using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuest2
{
    public static class GeneratorNumbers
    {
        // Связанный список
        public static LinkedList<float> GenerateLinkedList()
        {
            Random rand = new Random();

            LinkedList<float> array = new LinkedList<float>();
            //наполняем список случайным колличеством случайных числами
            for (int i = 0; i < rand.Next(3, 25); i++)
            {
                array.AddLast(rand.Next(1, 9999));
            }
            return array;
        }

        // Список с возможностью указать диапазон кол-ва ячеек
        public static LinkedList<float> GenerateLinkedList(int sizeListFrom, int sizeListTo)
        {
            Random rand = new Random();

            LinkedList<float> array = new LinkedList<float>();
            // Наполняем список случайным колличеством случайных числами
            for (int i = 0; i < rand.Next(sizeListFrom, sizeListTo); i++)
            {
                array.AddLast(rand.Next(1, 9999));
            }
            return array;
        }

        // Список с полной настройкой
        public static LinkedList<float> GenerateLinkedList(int sizeListFrom, int sizeListTo, int sizeNumberFrom, int sizeNumberTo)
        {
            Random rand = new Random();

            LinkedList<float> array = new LinkedList<float>();
            // Наполняем список случайным колличеством случайных числами
            for (int i = 0; i < rand.Next(sizeListFrom, sizeListTo); i++)
            {
                array.AddLast(rand.Next(sizeNumberFrom, sizeNumberTo));
            }
            return array;
        }

        // Отображает случайный список
        public static string ShowLinkedList()
        {            
            string text = string.Join(", ", GenerateLinkedList()); 
            return text;
        }

        // Отображает заданный список
        public static string ShowLinkedList(LinkedList<float> array)
        {
            string text = string.Join(", ", array);
            return text;
        }

        public static string ShowLinkedList(LinkedList<int> array)
        {
            string text = string.Join(", ", array);
            return text;
        }
    }
}
