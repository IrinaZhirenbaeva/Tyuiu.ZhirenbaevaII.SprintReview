using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.SprintReview4.Lib;

namespace Tyuiu.ZhirenbaevaII.SprintReview4
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                DataService ds = new DataService();
                Random rnd = new Random();

                Console.Title = "Спринт Review | Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1";

                Console.WriteLine("**");
                Console.WriteLine(" Спринт #4                                                               ");
                Console.WriteLine(" Тема: Обработка структурных типов                                        ");
                Console.WriteLine(" Задание #7                                                             ");
                Console.WriteLine(" Вариант #18                                                        ");
                Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                      ");
                Console.WriteLine("**");
                Console.WriteLine("* УСЛОВИЕ:                                                                ");
                Console.WriteLine(" Дана строка из одноразрядных цифр 145258749635789");
                Console.WriteLine(" Преобразуйте ее в матрицу 5 на 3 и подсчитайте произведение четных чисел.    ");
                Console.WriteLine("**");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
                Console.WriteLine("**");

                int n = 5; int m = 3;
                int[,] array = new int[n, m];
                string str = "145258749635789";
                int index = 0;

                Console.WriteLine("\nМассив:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write($"{str[index]} \t ");
                        index++;
                    }

                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                int res = ds.Calculate(n, m, str);

                Console.WriteLine("произведение четных чисел" + res);

                Console.ReadKey();
            }
        }
    }
}
    

