using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class FactorialCalculator
    {
        public static int calc (int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * calc(number - 1);
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствие!" + "\n" + "Данная программа вычислият факториал числа, введенного с клавиатуры");
            Console.WriteLine("\n" + "Введите любое целое число:");            
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = FactorialCalculator.calc(num);
            Console.WriteLine("\n" + "Факториал введенного числа равен:" + fact);
            Console.ReadKey();
        }
    }
}
