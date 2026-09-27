//***********************************************************
//* Практическая работа № 5                                 *
//* Выполнил:Разуммов М. И., группы 2-ИСП                   *
//* Задание: составить  программу работы линейного алгоритма*
//***********************************************************
using System;

namespace Пр5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); //Очиска 
            Console.Title = "Практическая работа №5";
            double l, w, h, x, y; //Ввод переменных
            Console.WriteLine("Здравствуйте");
            Console.WriteLine("Введите длину кирпича ");
            Console.Write("l= ");
            l = Convert.ToDouble(Console.ReadLine()); //Ввод переменных с клавиатуры
            Console.WriteLine("Введите ширину кирпича");
            Console.Write("w= ");
            w = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту кирпича");
            Console.Write("h= ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стороны прямоугольного отверстия");
            Console.Write("x= ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y= ");
            y = Convert.ToDouble(Console.ReadLine());

            if (l <= x && w <= y)//проверка 1 грани
            { Console.WriteLine("--Результат--");
                Console.WriteLine(" Кирпич пройдёт "); }
            else
            { if (w <= x && l <= y)//проверка перевёрнутой грани на 90 градусов
                { Console.WriteLine("--Результат--");
                    Console.WriteLine(" Кирпич пройдёт "); }
                else
                {
                    if (l <= x && h <= y)//проверка 2 грани
                    { Console.WriteLine("--Результат--");
                        Console.WriteLine(" Кирпич пройдёт "); }
                    else
                    {
                        if (l <= y && h <= x)//проверка перевёрнутой грани на 90 градусов
                        { Console.WriteLine("--Результат--");
                            Console.WriteLine(" Кирпич пройдёт "); }
                        else
                        {
                            if (w <= x && h <= y)//проверка 3 грани
                            { Console.WriteLine("--Результат--");
                                Console.WriteLine(" Кирпич пройдёт "); }
                            else
                            {
                                if (w <= x && h <= y)//проверка перевёрнутой грани на 90 градусов
                                { Console.WriteLine("--Результат--");
                                    Console.WriteLine(" Кирпич пройдёт "); }
                                else
                                { Console.WriteLine("--Результат--");
                                    Console.WriteLine(" Кирпич не пройдёт "); }
                            }
                        }
                    }
                }
            }
            Console.ReadKey(); // Задержка
        }
    }
}