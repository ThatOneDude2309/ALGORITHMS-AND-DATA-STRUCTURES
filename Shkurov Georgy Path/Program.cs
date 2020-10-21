using System;

namespace algorithm
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
                int value1 = 3;
                int value2 = 4;
                int value3 = 0;
                value3 = value1;
                value1 = value2;
                value2 = value3;
                Console.WriteLine(" " + value1 + " " + value2);
                Console.ReadKey();
            }

            //Задача 2
            {
                int i = 20;
                int j = 30;
                i = i * 3;
                j = j + 12;
                Console.WriteLine(i.ToString() + " " + j.ToString());
                Console.ReadKey();
            }
            //Задача 3
            {
                int milk = 50;
                int matches = 20;
                int amountMatches = 120;
                int amountMilk = 210;
                int sum = milk * amountMilk + matches * amountMatches;

                Console.WriteLine(" " + sum);
                Console.ReadKey();
            }
            //Задача 4
            {
                int i = Convert.ToInt32(Console.ReadLine(1));
                int j = Convert.ToInt32(Console.ReadLine(2));
                int sum = i + j;
                Console.WriteLine("Summ is: " + sum);
                int mult = i * j;
                Console.WriteLine("Multiplication is: " + mult);
                int diff = i - j;
                Console.WriteLine("Difference is: " + diff);
                Console.ReadKey();
            }
            //Задача 5
            {
                float q = 20.1f;
                float w = 5.3f;
                Console.WriteLine(q / w);
                Console.ReadKey();
            }
            //Задача 6
            {
                int n = 37;
                int z = n % 10;
                int y = n / 10;
                Console.WriteLine(z + y);
                Console.ReadKey();
            }
        }
    }
}
    

