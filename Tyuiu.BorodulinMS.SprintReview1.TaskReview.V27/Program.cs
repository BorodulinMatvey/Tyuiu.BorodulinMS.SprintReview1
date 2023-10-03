using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BorodulinMS.SprintReview1.TaskReview.V27.Lib;


namespace Tyuiu.BorodulinMS.SprintReview1.TaskReview.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Бородултин М. С. | ИИПб-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Арифсетические операторы С#                                      *");
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #27                                                            *");
            Console.WriteLine("* Выполнил: Бородулин Матвей Сергеевич | ИИПб-23-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные *");
            Console.WriteLine("* и вычисляет по формуле:(cosx^2+siny^2)/(siny+1)-(x*y-12)/(15+cosx)     *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double x, y;
            Console.WriteLine("Введите первое значение x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе значение y:");
            y = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}
