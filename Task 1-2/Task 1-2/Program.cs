using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2
{
    class ArrayGenerator
    {
        private static int[] Generator()
            //Генератор случайных массивов размером от 2 до 30 элементов со значением в диапазоне от 1 до 100.
        {
            Random rnd = new Random();
            int a = rnd.Next(2, 30);
            int[] newarray = new int[a];
            for (int i = 0; i < newarray.Length; i++)
            {
                newarray[i] = rnd.Next(1, 100);
            }
            return newarray;
        }
        public static int[] Array = Generator();
    }
    class BubbleSort 
    {
        public static int[] ArraySort(int[] array)
        //Сортировка массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                    if (array[i] > array[j])
                    {
                        swap(ref array[i], ref array[j]);                      
                    }
            }
            return array;
        }
        private static void swap (ref int e1, ref int e2)
            //функция перестановки элементов
        {
            int a = e1;
            e1 = e2;
            e2 = a;
        }
    }
    class Searcher
    {
        public static void numsearch (int [] array, int num)
            //функция поиска элемента с заданным значением
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                    Console.WriteLine("\n" + "В массиве имеется элемент с искомым значением, индекс элемента:" + i);
                
                
            }
        }
    }
    class Program
    {
        static public void Print (int [] array)
            //Функция вывода массива на экран
        {
            Console.WriteLine(String.Join(" ", array));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствие!" +"\n" + "Данная программа генерирует массив случайных чисел, сортирует его и проверяет его на наличие желаемого значения");
            
            Console.WriteLine("\n"+"Исходный массив:");
            Print(ArrayGenerator.Array);

            Console.WriteLine("\n" + "Массив после сортировки:");
            Print(BubbleSort.ArraySort(ArrayGenerator.Array));

            Console.WriteLine("\n" + "Введите целочисленное число от 1 до 100, наличие которого необходимо проверить:");
            int num;
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 101)
                {
                    Console.WriteLine("Введено некорректное число");
                }
            } while (num > 101);
            Searcher.numsearch(BubbleSort.ArraySort(ArrayGenerator.Array), num);
            Console.ReadKey();
        }
    }
}
