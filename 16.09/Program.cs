using System;

namespace _16._09
{
        class Program
        {

        static void swap(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;

        }
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    swap(ref array[i], ref array[i + 1]);
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
            Console.ReadKey();
        }
    }
    
}
