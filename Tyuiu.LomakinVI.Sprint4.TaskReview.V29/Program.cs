using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LomakinVI.Sprint4.TaskReview.V29.Lib;

namespace Tyuiu.LomakinVI.Sprint4.TaskReview.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int n = 4;
            int m = 3;
            int[,] mtrx = new int[n, m];

            string strochenka = "983157642891";

            Console.Title = "Спринт #4 | Выполнил: Ломакин В. И. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание SprintReview                                                    *");
            Console.WriteLine("* Вариант 15                                                              *");
            Console.WriteLine("* Выполнил: Ломакин Владислав Игоревич | ИИПб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"983157642891\". Преобразуйте ее в     *");
            Console.WriteLine("* матрицу 4 на 3 и подсчитайте сумму четных чисел.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int index = 0;

            Console.WriteLine("Исходный массив: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{strochenka[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(n, m, strochenka);

            Console.WriteLine("Сумма четных чисел в матрице = " + result);
            Console.ReadKey();
        }
    }
}
