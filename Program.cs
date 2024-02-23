using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////практикум по счёту в moodle: 10
            ////Задача 1. Дано целое число n, указывающее номер дня недели от 1 до 7.
            ////По указанному номеру n вывести название соответствующего дня недели.
            Console.Write("Введите день недели: ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("понедельник");
                    break;
                case 2:
                    Console.WriteLine("вторник");
                    break;
                case 3:
                    Console.WriteLine("среда");
                    break;
                case 4:
                    Console.WriteLine("четверг");
                    break;
                case 5:
                    Console.WriteLine("пятница");
                    break;
                case 6:
                    Console.WriteLine("суббота");
                    break;
                case 7:
                    Console.WriteLine("воскресенье");
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Console.ReadKey();

            ////Задача 2. В зависимости от порядкового номера месяца (1, 2, ... , 12) вывести на экран его название
            ////(январь, февраль, ... , декабрь).

            Console.Write("Введите номер месяца: ");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Январь");
                    break;
                case 2:
                    Console.WriteLine("Февраль");
                    break;
                case 3:
                    Console.WriteLine("Март");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    break;
                case 7:
                    Console.WriteLine("Июль");
                    break;
                case 8:
                    Console.WriteLine("Август");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Декабрь");
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Console.ReadKey();

            ////Задача 3. По номеру месяца вывести название времени года.

            Console.Write("Введите номер месяца что б узнать время года: ");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Зима");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Лето");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Осень");
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Console.ReadKey();

            //Задача 4. Вывести название предмета по введенной первой букве: ф – физика, м – математика, и – история, г – география, б – биология.

            Console.Write("Введите одну букву из названия предмета например: Ф, М, И, Г, Б. ");
            char d = char.Parse(Console.ReadLine()); 
            switch (d) 
            {
                case 'Ф':
                    Console.WriteLine("Физика");
                    break;
                case 'М':
                    Console.WriteLine("Математика");
                    break;
                case 'И':
                    Console.WriteLine("История");
                    break;
                case 'Г':
                    Console.WriteLine("География");
                    break;
                case 'Б':
                    Console.WriteLine("Биология");
                    break;
                    default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Console.ReadKey ();




        }
    }
}
