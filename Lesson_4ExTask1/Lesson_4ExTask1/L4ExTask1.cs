using System;

namespace Lesson_4ExTask1
{
    class L4ExTask1
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int x = 0;
            double help;
            double y;
            while (counter <= 3)
            {
                Console.WriteLine("Введите x: ");
                x = Int32.Parse(Console.ReadLine());
                help = x - 3;
                y = (4 * Math.Pow(help, 6)) - (7 * Math.Pow(help, 3)) + 2;
                Console.WriteLine("x = " + x + ";y = " + y);
                Console.WriteLine("+++++");
                counter++;
            }
        }
    }
}
