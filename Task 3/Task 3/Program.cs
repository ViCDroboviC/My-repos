using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class EqualsDeleter
    {
        public static string delete(string str)
            //Функция поиска повторяющихся слов
        {
            var outputTextBuilder = new StringBuilder();
            //используется для построения новой строки из неповторяющихся слов  
            var separators = new String[] { " ", ",", ";", ", " };
            var splittedTextArray = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < splittedTextArray.Length; i++)
            {
                if (string.IsNullOrEmpty(splittedTextArray[i]))
                {
                    continue;
                }

                    bool eq = true;
                    for (int j = 0; j < splittedTextArray.Length; j++)
                    {
                        if (comparsion(splittedTextArray[i], splittedTextArray[j]) && i != j)
                        {
                            eq = false;
                            break;
                        }
                    }
                    if (eq)
                    {
                        outputTextBuilder.Append(splittedTextArray[i] + " ");
                    }

                
            }
            if (outputTextBuilder.Length > 0)
                outputTextBuilder.Remove(outputTextBuilder.Length - 1, 1);
            return outputTextBuilder.ToString();
        }
        private static bool comparsion (string str1, string str2)
        {
            return str1.Equals(str2, StringComparison.InvariantCultureIgnoreCase);           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствие" + "\n" + "Данная программа выводит на экран все неповторяющиеся слова в строке.");
            Console.WriteLine("\n" + "Введите строку:");
            string str = Console.ReadLine();
            Console.WriteLine(EqualsDeleter.delete(str));
            Console.ReadLine();
        }
    }
}
