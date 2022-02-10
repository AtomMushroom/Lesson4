using System;

namespace Lesson_4Task5
{
    class L4Task5
    {
        static void Main(string[] args)
        {
            int numb;
            int counter = 0;
            int max = int.MinValue;
            Console.WriteLine("Введите последовательность чисел и закончите ввод нулем");
            do
            {
                numb = Int32.Parse(Console.ReadLine());
                if (numb!=0 && numb > max)
                {
                    max = numb;
                    counter++;
                }
            } while (numb != 0);
            Console.WriteLine("Максимальное число: " + max);
            Console.WriteLine("Его порядковый номер: " + counter);
        }
    }
}
