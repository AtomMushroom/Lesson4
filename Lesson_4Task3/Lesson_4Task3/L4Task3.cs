using System;

namespace Lesson_4Task2
{
class L4Task3
    {
        static void Main(string[] args)
        {
            int counter = 10;
            int product = 1;
            while (counter<=20)
            {
                product *= counter;
                counter += 2;
            }
            Console.WriteLine("10 * 12 * 14 * 16 * 18 * 20 = " + product);
        }
    }
}
