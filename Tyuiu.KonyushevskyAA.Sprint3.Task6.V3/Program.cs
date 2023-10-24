using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KonyushevskyAA.Sprint3.Task6.V3.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint3.Task6.V3
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Конюшевский А.А | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #3                                                                    *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                     *");
            Console.WriteLine("* Задание #6                                                                   *");
            Console.WriteLine("* Вариант #3                                                                   *");
            Console.WriteLine("* Выполнил Конюшевский Алексей Александрович  | ИИПб-23-2                      *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих числовому  *");
            Console.WriteLine("* отрезку [13, 19] сумму всех делителей больше 8.                              *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");


            int startValue1 = 13;
            int stopValue1 = 19;

            Console.WriteLine("Начало отрезка = " + startValue1);
            Console.WriteLine("Конец отрезка = " + stopValue1);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Сумма делителей больших 8 отрезка = " + ds.GetSumTheDivisors(startValue1, stopValue1));
            Console.ReadKey();
        }
    }
}
