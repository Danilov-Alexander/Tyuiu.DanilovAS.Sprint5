using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DanilovAS.Sprint5.Task5.V21.Lib;
using System.IO;

namespace Tyuiu.DanilovAS.Sprint5.Task5.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
          
            Console.Title = "Спринт #5 | Выполнил: Данилов А. С. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич | ИСТНб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine(@"* Дан файл С:\DataSprint5\InPutDataFileTask5V21.txt Создать папку в      *");
            Console.WriteLine(@"* ручную С:\DataSprint5\ и скопировать в неё файл) в котором есть набор  *");
            Console.WriteLine("* значений. Найти факториал наибольшего целого числа, которое делится на 2*");
            Console.WriteLine("* в файле. Полученный результат вывести на консоль.У вещественных значений*");
            Console.WriteLine("* округлить до трёх знаков после запятой.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V21.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Факториал наибольшего числа равен = " + res);
            Console.ReadKey();
        }
    }
}
