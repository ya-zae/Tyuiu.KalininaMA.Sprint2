using Tyuiu.KalininaMA.Sprint2.Task2.V17.Lib;

namespace Tyuiu.KalininaMA.Sprint2.Task2.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Калинина М.А. | Рппб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* спринт #2                                                               *");
            Console.WriteLine("* Тема : Операции сравнения                                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнила: Калинина Мария Александровна | Рппб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной      *");
            Console.WriteLine("* области.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Введите значение переменной x : ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Введите значение переменной y : ");
            int y = Convert.ToInt32(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка находится вне заштрихованной области");
            }
        }
    }
}