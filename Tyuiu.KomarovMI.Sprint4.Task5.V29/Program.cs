using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KomarovMI.Sprint4.Task5.V29.Lib;

namespace Tyuiu.KomarovMI.Sprint4.Task5.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd=new Random();
            Console.Title = "Спринт #4 | Выполнил: Комаров М.И. | ПКТБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #4                                                                *");
            Console.WriteLine("* Тема:                                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Комаров Максим Игоревич | ПКТБ-23-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -9 до 9. Найти количество          *");
            Console.WriteLine("* положительных элементов.                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите колличество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите колличество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] mtrx = new int[rows, columns];
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mtrx[i, j] = rnd.Next(-9, 9);
                }
            }

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res;
            res = ds.Calculate(mtrx);
            Console.WriteLine("Количество положительных элементов массива = " + res);

            Console.ReadKey();
        }
    }
}
