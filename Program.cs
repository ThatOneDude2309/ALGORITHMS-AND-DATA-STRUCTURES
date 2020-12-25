using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tower = new int[45];
            Random rnd = new Random();

            for (int i = 0; i < tower.Length; i++)
                tower[i] = rnd.Next(3, 9);

            int j = 0;
            int sum = 0;

            do
            {
                sum += tower[j];
                j++;
            } while (j < tower.Length);

            Console.WriteLine(sum);
        }
    }
}
