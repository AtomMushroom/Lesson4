using System;

namespace Lesson_4ExTask3
{
    class L4ExTask3
    {
        static void Main(string[] args)
        {
            for (int y = 1; y < 9; y++)
            {
                Console.WriteLine();
                for (int x = 1; x<9; x++)
                {
                    //Console.Write(y);
                    if (y % 2 != 0)
                    {
                        //Console.Write("X");
                        if (x % 2 !=0)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("O");
                        }
                    }
                    else
                    {
                        //Console.Write("O");
                        if (x % 2 != 0)
                        {
                            Console.Write("O");
                        }
                        else
                        {
                            Console.Write("X");
                        }
                    }
                }
            }
        }
    }
}

