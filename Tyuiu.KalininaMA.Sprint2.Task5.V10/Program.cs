using Tyuiu.KalininaMA.Sprint2.Task5.V10.Lib;

namespace Tyuiu.KalininaMA.Sprint2.Task5.V10
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
            Console.WriteLine("* Выполнила: Калинина Мария Александровна | Рппб-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("* eсловие: Дата некоторого дня характеризуется тремя натуральными числами *");
            Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число).По заданным g, n и m   *");
            Console.WriteLine("*  определить дату предыдущего дня. Заданный год не является високосным.  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* x = 135, y = 755                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите Год: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите Месяц: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите День: ");
            int day = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindDateOfPreviousDay(year, month, day);
            Console.WriteLine($"Вы ввели: {day}.{month}.{year}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadLine();
        }
    }
}