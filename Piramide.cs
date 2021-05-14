using System;
using static System.Console;

namespace ThePiramide
{
    class Piramide
    {
        static void Main(string[] args)
        {
            int rows = 7;
            int maxStars = 13;

            for (int level = 0; level < rows*2; level+=2)
            {
                for (int i = 0; i < maxStars-level; i++)
                {
                    Write(" ");
                }
                for (int i = 0; i < level; i++)
                {
                    Write("* ");
                }
                WriteLine("*");
            }
        }
    }
}
