using System;

namespace second
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            var n = int.Parse(Console.ReadLine());
            int inMin = 0;
            int inMax = 0;
            for(int i = 0; i < n; i++)
            {
                if (n > inMax)
                {
                    inMax = n;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (n < inMin)
                {
                    inMin = n;
                }
            }
            Console.WriteLine("MIN" + inMin);
            Console.WriteLine("MAX" + inMax);
        }
    }
}
