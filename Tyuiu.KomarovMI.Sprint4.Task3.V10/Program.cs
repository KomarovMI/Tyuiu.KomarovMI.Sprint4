using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KomarovMI.Sprint4.Task3.V10.Lib;

namespace Tyuiu.KomarovMI.Sprint4.Task3.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Комаров М.И. | ПКТБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #4                                                                *");
            Console.WriteLine("* Тема:                                                                   *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Комаров Максим Игоревич | ПКТБ-23-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 4 до 8. Найдите максимальный     *");
            Console.WriteLine("* элемент в третьей строке массива.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new int[5, 5]{ { 5,7,6,6,5},
                                         { 5,5,5,4,6},
                                         { 8,5,7,4,7},
                                         { 7,6,7,4,7},
                                         { 5,8,7,8,8} };
            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / rows;

            Console.WriteLine("Массив:");
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < colums; j++)
                {
                    Console.Write($"{array[i, j]} \t");

                }
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine("Наибольшее число в 3 строке = " + res);
            Console.ReadKey();


        }
    }
}
