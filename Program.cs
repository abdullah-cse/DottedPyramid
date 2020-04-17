using System;

namespace Pyramid
{
    class Program
    {
        static void DrawPyramid(int n)
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2*i-1; k++)
                {
                    Console.Write("*" + "");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Length of the Pyramid");
            DrawPyramid(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
