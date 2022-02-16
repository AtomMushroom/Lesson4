using System;

namespace Lesson_4ExTask2
{
    class L4ExTask2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x (1-8): ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y (1-8): ");
            int y = int.Parse(Console.ReadLine());

            int sum = x + y;
            Console.WriteLine("Этот квадрат белый: ");
            Console.WriteLine(sum % 2 != 0);
        }
    }
}
