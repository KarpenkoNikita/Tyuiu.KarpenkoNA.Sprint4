using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KarpenkoNA.Sprint4.Task3.V20.Lib;

namespace Tyuiu.KarpenkoNA.Sprint4.Task3.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[5, 5] { { 8, 7, 7, 8, 5 },
                                          { 4, 3, 5, 3, 6 },
                                          { 5, 3, 8, 6, 3 },
                                          { 6, 3, 8, 5, 4 },
                                          { 3, 6, 8, 3, 4 } };

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Карпенко Н.А. | АСОиУБ-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Карпенко Никита Андреевич |  АСОиУБ-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 8. Найдите минимальный      *");
            Console.WriteLine("* элемент в первом столбце массива.                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив: ");
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

            int res = ds.Calculate(mtrx);

            Console.WriteLine("Минимальный элемент первого столбца = " + res);
            Console.ReadKey();
        }
    }
}
