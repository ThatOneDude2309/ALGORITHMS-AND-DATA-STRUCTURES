using System;

namespace conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Задача 1
                //Задача 2
                //Задача 3
                //Задача 4
                //Задача 5
                //Задача 6
            }

            //Задача 1
            { 
                Random rnd = new Random();

                int i = rnd.Next(0, 4);
                int j = rnd.Next(0, 4);
                {
                    if (i % 2 == 0 && j % 2 == 0)
                        Console.WriteLine($"i = {i}, Число четное");
                    else
                        Console.WriteLine($"1 = {i}, Число нечетное");  
                }
            }

            // Задача 2
            { 

                int a, b, d;

                Console.WriteLine("Введите три числа : ");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                d = Convert.ToInt32(Console.ReadLine());
                {
                    if ((a >= b) && (a >= d))
                        Console.WriteLine("Наибольшее Число" + " " + a);
                    else if ((b >= a) && (b >= d))
                        Console.WriteLine("Наибольшее Число" + " " + b);
                    else if ((d >= a) && (d >= b))
                        Console.WriteLine("Наибольшее Число" + " " + d);
                }
            }

            // Задача 3
            { 

                Console.WriteLine("Введите Радиус окружности:");
                int Radios = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Введите кординату x:");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите кординату y:");
                int y = Convert.ToInt32(Console.ReadLine());


                if (x * x + y * y < Radios * Radios)
                {
                    Console.WriteLine("Точка лежит внутри окружности!");
                }
                else if (x * x + y * y == Radios * Radios)
                {
                    Console.WriteLine("Точка лежит на окружности!");
                }
                else
                {
                    Console.WriteLine("Точка вне круга!");
                }

            }

            // Задача 4
            {
                Random rnd = new Random();
                int numb = rnd.Next(0, 31);

                switch (numb)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        Console.WriteLine($"{numb} Попало в 1-й диапазон");
                        break;


                    case 11:
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                    case 16:
                    case 17:
                    case 18:
                    case 19:
                    case 20:
                        Console.WriteLine($"{numb} Попало в 2-й диапозон");
                        break;


                    case 21:
                    case 22:
                    case 23:
                    case 24:
                    case 25:
                    case 26:
                    case 27:
                    case 28:
                    case 29:
                    case 30:
                        Console.WriteLine($"{numb} Попало в 3-й диапозон");
                        break;
                }
            }

            //Задача 5
            { 

                Console.WriteLine("Введите год!: ");

                string str = Console.ReadLine();
                int year = int.Parse(str);
                if (year % 400 == 0)

                {
                    Console.WriteLine("Високосный год!");
                }

                else if (year % 100 == 0)
                    Console.WriteLine("Столетие!");
                else if (year % 4 != 0)
                    Console.WriteLine("Обычный год!");
                else
                    Console.WriteLine("Високосный год!");
            }

            //Задача 6
            { 

                Console.WriteLine("Напишите чему равна каждая сторона треугольника");
                string side = Console.ReadLine();
                string side1 = Console.ReadLine();
                string side2 = Console.ReadLine();

                int x = int.Parse(side);
                int x1 = int.Parse(side1);
                int x2 = int.Parse(side2);

                {
                    if ((x == x1) && (x1 == x2)) Console.WriteLine("Труегольник равнобедренный!");
                    else if ((x == 0) || (x1 == 0) || (x2 == 0)) Console.WriteLine("Ошибка!");

                    if ((x < x1 + x2) && (x1 < x + x2) && (x2 < x + x1)) Console.WriteLine("Треугольник существует");
                    else Console.WriteLine("Ошибка!");
                }

                Console.ReadKey();
            }
        }
    }
}
