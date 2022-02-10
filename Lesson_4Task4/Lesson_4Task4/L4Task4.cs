using System;

namespace Lesson_4Task3
{
    class L4Task4
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double numb;
            int counter = 1;
            while (counter <= 5)
            {
                numb = Double.Parse(Console.ReadLine());
                sum += numb;
                counter++;
            }
            Console.WriteLine("Сумма введенных чисел: " + sum);
        }
    }
}
