using System;

namespace Mini_Game
{
    class Program
    {
        private static void DrawStar(int left, int top)
        {
            Console.ForegroundColor = Console.BackgroundColor;
            Console.SetCursorPosition(left, top);
            Console.Write('*');
        }

        static void Main(string[] args)
        {           
            Console.Clear();           
            int leftMin = Console.WindowWidth / 4,
                topMin = Console.WindowHeight / 4;
            int leftMax = 3 * Console.WindowWidth / 4,
                topMax = 3 * Console.WindowHeight / 4;
           
            Console.SetCursorPosition(leftMin - 1, topMin - 1);
            Console.Write('+');
            Console.SetCursorPosition(leftMax + 1, topMax + 1);
            Console.Write('+');
            Console.SetCursorPosition(leftMin - 1, topMax + 1);
            Console.Write('+');
            Console.SetCursorPosition(leftMax + 1, topMin - 1);
            Console.Write('+');
            
            int i = leftMin - 1;
            while (i++ < leftMax)
            {              
                Console.SetCursorPosition(left: i, top: topMin - 1);
                Console.Write('-');                
                Console.SetCursorPosition(left: i, top: topMax + 1);
                Console.Write('-');
            }           
            int j = topMin - 1;
            while (j++ < topMax)
            {
                Console.SetCursorPosition(leftMin - 1, i);
                Console.WriteLine('|');
                Console.SetCursorPosition(leftMax + 1, i);
                Console.WriteLine('|');
            }
           
            int left = Console.WindowWidth / 2,
                top = Console.WindowHeight / 2;
            Console.SetCursorPosition(left, top);
            Console.Write('*');

            Random rnd = new Random();            
            int badLeft = rnd.Next(leftMin, leftMax);
            int badTop = rnd.Next(topMin, topMax);
            Console.SetCursorPosition(badLeft, badTop);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write('@');
           
            int goodLeft = rnd.Next(leftMin, leftMax);
            int goodTop = rnd.Next(topMin, topMax);
            Console.SetCursorPosition(goodLeft, goodTop);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('@');

            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.A) 
                {
                    

                    DrawStar(left, top);
                    if ((left - 1) <= leftMin)
                    {
                        left = Console.WindowWidth / 2;
                        top = Console.WindowHeight / 2;
                    }
                    else
                    {                        
                        --left;
                    }
                }
                if (key.Key == ConsoleKey.D) 
                {
                    DrawStar(left, top);
                    if ((left + 1) >= leftMax)
                    {
                        left = Console.WindowWidth / 2;
                        top = Console.WindowHeight / 2;
                    }
                    else
                    {                        
                        ++left;
                    }
                }

                if (key.Key == ConsoleKey.W) 
                {
                    DrawStar(left, top);
                    if ((top - 1) <= topMin)
                    {
                        left = Console.WindowWidth / 2;
                        top = Console.WindowHeight / 2;
                    }
                    else
                    {                        
                        --top;
                    }
                }
                if (key.Key == ConsoleKey.S) 
                {
                    DrawStar(left, top);
                    if ((top + 1) >= topMax)
                    {
                        left = Console.WindowWidth / 2;
                        top = Console.WindowHeight / 2;
                    }
                    else
                    {                   
                        ++top;
                    }
                    
                }
                if ((left - 1) == badLeft && top == badTop || 
                    (left + 1) == badLeft && top == badTop || 
                    (top + 1) == badTop && left == badLeft || 
                    (top - 1) == badTop && left == badLeft)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();

                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    return;
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(left, top);
                Console.Write('*');
            }
            while (key.Key != ConsoleKey.Escape);

            Console.ReadKey();
        }
    }
}
