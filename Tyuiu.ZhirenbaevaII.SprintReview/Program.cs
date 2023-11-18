using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.SprintReview.Lib;

namespace Tyuiu.ZhirenbaevaII.SprintReview
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                DataService ds = new DataService();

                Console.Title = "Спринт Review | Выполнила: Жиренбаева И.И| ИСТНб-23-1";

                Console.WriteLine("**");
                Console.WriteLine(" Спринт #3                                                               ");
                Console.WriteLine(" Тема: Алгоритмы циклической структуры                                      ");
                Console.WriteLine(" Задание #7                                                             ");
                Console.WriteLine(" Вариант #9                                                            ");
                Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                     ");
                Console.WriteLine("**");
                Console.WriteLine("* УСЛОВИЕ:                                                               ");
                Console.WriteLine(" Написать программу, которая выводит таблицу значения функции              ");
                Console.WriteLine(" на заданном диапозоне [-5;5]. При делении на ноль вернуть значение ноль.  ");
                Console.WriteLine("**");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       ");
                Console.WriteLine("**");

                int startValue = -5;
                int stopValue = 5;

                Console.WriteLine("Старт шага = " + startValue);
                Console.WriteLine("Конец шага = " + stopValue);
                int len = ds.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);

                Console.WriteLine("**");
                Console.WriteLine(" РЕЗУЛЬТАТ:                                                              ");
                Console.WriteLine("**");

                Console.WriteLine("+----------+-----------+");
                Console.WriteLine("|    X     |   f(X)    |");
                Console.WriteLine("+----------+-----------+");

                for (int i = 0; i <= len - 1; i++) 
                {
                    Console.WriteLine("|{0,5:d}     |   {1,6:f2}   |", startValue, valueArray[i]);
                    startValue++;
                }
                Console.WriteLine("+----------+-----------+");

                Console.ReadKey();

            }
        }
    }
}
    

