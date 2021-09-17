using System;


namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pool = new string[4];
            pool[1] = "Камень";
            pool[2] = "Ножницы";
            pool[3] = "Бумага";
            var rnd = new Random();
            int coincidental = rnd.Next(1, 4);
            string coincidental2 = pool[coincidental];

            Console.Write("Что вы хотите поставить: 1 – камень, 2 – ножницы, 3 – бумага\n");
            string Choise = Console.ReadLine();
            Console.WriteLine("Компьютер выбирает:" + coincidental2);
            switch (Choise)
            {
                case "1":
                    Console.WriteLine("Камень vs {0}", coincidental2);

                    if (coincidental2 != pool[1] && coincidental2 != pool[2])
                        Console.WriteLine("Ты проиграл.");
                    else if (coincidental2 != pool[1] && coincidental2 != pool[3])
                        Console.WriteLine("Ты победил.");
                    else
                        Console.WriteLine("Ничья.");
                    break;
                case "2":
                    Console.WriteLine("Ножницы vs {0}", coincidental2);

                    if (coincidental2 != pool[2] && coincidental2 != pool[1])
                        Console.WriteLine("Ты победил.");
                    else if (coincidental2 != pool[2] && coincidental2 != pool[3])
                        Console.WriteLine("Ты проиграл.");
                    else
                        Console.WriteLine("Ничья.");
                    break;
                case "3":
                    Console.WriteLine("Бумага vs {0}", coincidental2);
                    if (coincidental2 != pool[3] && coincidental2 != pool[2])
                        Console.WriteLine("Ты победил.");
                    else if (coincidental2 != pool[3] && coincidental2 != pool[1])
                        Console.WriteLine("Ты проиграл.");
                    else
                        Console.WriteLine("Ничья.");
                    break;
            }


        }
    }
}
