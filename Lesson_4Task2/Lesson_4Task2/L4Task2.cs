using System;

namespace Lesson_4Task2
{
    class L4Task2
    {
        static void Main(string[] args)
        {
            int counter1 = 15;
            int counter2 = 15;
            while (counter1 >= 0)
            {
                Console.Write(counter1 + " ");
                counter1 -= 3;
            }
            Console.WriteLine();
            do
            {
                Console.Write(counter2 + " ");
                counter2 -= 3;
            } while (counter2 >= 0);
        }
    }
}
