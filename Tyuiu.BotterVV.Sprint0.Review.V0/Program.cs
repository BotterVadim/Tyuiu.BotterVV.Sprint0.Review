using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BotterVV.Sprint0.Review.V0.Lib;

namespace Tyuiu.BotterVV.Sprint0.Review.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Боттер В.В. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #8                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Боттер Вадим Валерьевич | ПКТб-23-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая                            *");
            Console.WriteLine("* вычисляет (x + y + z) * 5                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите z: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine(x + ", ");
            Console.WriteLine(y + ", ");
            Console.WriteLine(z + ", ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(DataService.Calc(x, y, z));
            Console.ReadKey();
        }
    }
}
