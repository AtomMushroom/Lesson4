using System;

namespace Lesson_4Task1
{
    class L4Task1
    {
        static void Main(string[] args)
        {
            int counter1 = 3;
            int counter2 = 3;
            while (counter1<=21)
            {
                Console.Write(counter1 + " ");
                counter1 += 2;
            }
            Console.WriteLine();
            do
            {
                Console.Write(counter2 + " ");
                counter2 += 2;
            } while (counter2 <= 21);
        }
    }
}
