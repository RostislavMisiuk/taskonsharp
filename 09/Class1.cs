using System;

namespace ConsoleApp5
{
    partial class Car
    {
        private string Name { get; set; }
        private int MaxSpeed { get; set; }
        private string Productor { get; set; }
        private string Colour { get; set; }
        private int Year { get; set; }
        public static int FirstCar { get; set; }
        public static string Engine { get; set; }

        public Car()
        {
            Name = "unknown";
            MaxSpeed = 0;
            Productor = "unknown";
            Colour = "unknown";
            Year = 0;
        }

        public Car(string Name, int MaxSpeed, string Productor, string Colour, int Year)
        {
            this.Name = Name;
            this.MaxSpeed = MaxSpeed;
            this.Productor = Productor;
            this.Colour = Colour;
            this.Year = Year;
        }
        public void Print()
        {
            Console.WriteLine("Name - " + Name);
            Console.WriteLine("Max Speed - " + MaxSpeed);
            Console.WriteLine("Productor - " + Productor);
            Console.WriteLine("Colour - " + Colour);
            Console.WriteLine("Year - " + Year);
        }
        public void Print(ref Car obj)
        {
            Console.WriteLine("Name - " + obj.Name);
            Console.WriteLine("Max Speed - " + obj.MaxSpeed);
            Console.WriteLine("Productor - " + obj.Productor);
            Console.WriteLine("Colour - " + obj.Colour);
            Console.WriteLine("Year - " + obj.Year);
        }
        class Program
        {
            static void Main(string[] args)
            {
                Car Auto = new Car();
                Car[] cars = new Car[5];
                for (int i = 0; i > cars.Length; i++)
                {
                    cars[i] = new Car();
                }
                Console.WriteLine("Введите название автомобиля");
                Auto.Name = Console.ReadLine();
                Console.WriteLine("Максимальная скорость автомобиля");
                Auto.MaxSpeed = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите производителя автомобиля");
                Auto.Productor = Console.ReadLine();
                Console.WriteLine("Введите цвет автомобиля");
                Auto.Colour = Console.ReadLine();
                Console.WriteLine("Введите год выпуска автомобиля");
                Auto.Year = int.Parse(Console.ReadLine());
                Console.WriteLine("Двигатель автомобиля" + Car.Engine);
                Console.WriteLine("Год выпуска первого автомобиля" + Car.FirstCar );
                Auto.Print();
            }
        }
    }
}