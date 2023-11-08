using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KarpenkoNA.Sprint4.Task6.V12.Lib;

namespace Tyuiu.KarpenkoNA.Sprint4.Task6.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Карпенко Н.А. | АСОиУБ-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Карпенко Никита Андреевич |  АСОиУБ-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Россия, Украина, Беларусь, Казахстан,      *");
            Console.WriteLine("* Молдова, Латвия, Эстония], используя класс Array, выведите элементы     *");
            Console.WriteLine("* массива, длина которых равна 7 символам.                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var coun = new string[] { "Россия", "Украина", "Беларусь", "Казахстан", "Молдова", "Латвия", "Эстония" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= coun.Length - 1; i++)
            {
                Console.WriteLine(coun[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Слова длинна которых = 7:");

            string[] res = ds.Calculate(coun);
            for (int i = 0; i <= res.Length - 1; i++)
            {
                Console.Write($"{res[i]} \t");
            }
            
            Console.ReadKey();
        }
    }
}
