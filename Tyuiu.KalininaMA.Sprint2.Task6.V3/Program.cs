using System;
using Tyuiu.KalininaMA.Sprint2.Task6.V3.Lib;

namespace Tyuiu.KalininaMA.Sprint2.Task6.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Калинина М.А. | Рппб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Cпринт #2                                                               *");
            Console.WriteLine("* Тема : Операции сравнения                                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Калинина Мария Александровна | Рппб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Составить программу, которая в зависимости от порядкового номера дня    *");
            Console.WriteLine("* недели (1, 2, …, 7) выводит на экран его название (понедельник, вторник,*");
            Console.WriteLine("*  …, воскресенье).                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите порядковый номер дня недели: ");

            int day = Convert.ToInt32(Console.ReadLine());


            string res;
            if ((day < 1) || (day > 7))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Это день недели: " + ds.FindDayName(day);
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}