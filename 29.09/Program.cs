using System;

namespace ConsoleApp3
{
    abstract class Device
    {
        public int isActive { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        
        public int DeviceStatus { get; set; }
        public void PowerOn()
        {
            if (DeviceStatus == 1)
            {
                Console.WriteLine("Вы включили устройство");
            }
            else
            {
                Console.WriteLine("Ошибка.");
            }    
        }
        public void PowerOff()
        {
            if (DeviceStatus == 0)
            {
                Console.WriteLine("Вы выключили устройство.");
            }
            else
            {
                Console.WriteLine("Ошибка.");
            }
        }
        public void DeviceS()
        {
            if (DeviceStatus == 1)
            {
                Console.WriteLine("Устройство работает.");
            }
            else
            {
                Console.WriteLine("Устройство выключенно.");
            }

        }
        public Device()
        {
            isActive =0;
            Manufacturer ="unknown";
            Model ="unknown";
            DeviceStatus = 0;
        }
        public Device(int isActive,string Manufacturer,string Model,int DeviceStatus)
        {
            this.isActive = isActive;
            this.Manufacturer = Manufacturer;
            this.Model = Model;
            this.DeviceStatus = DeviceStatus;
        }
        public void fullInfo()
        {
            Console.WriteLine("Производитель : " + Manufacturer);
            Console.WriteLine("Модель : " + Model);
            Console.WriteLine("Статус девайса 1-вкл,2-откл. : " + DeviceStatus);
        }
        class SmartPhone : Device
        {
            public string CPU { get; set; }
            public int ram { get; set; }
            public int storage { get; set; }
            public string screenSize { get; set; }

            public void powerOn()
            {
                if (DeviceStatus == 1)
                {
                    Console.WriteLine("SmartPhone is ready");
                }
                else
                {
                    Console.WriteLine("SmartPhone is off");
                }
            }

            public SmartPhone()
             {
                CPU = "unknown";
                ram = 0;
                storage = 0;
                screenSize = "unknown";
             }
            public SmartPhone(string CPU,int ram,int storage,string screenSize)
            {
                this.CPU = CPU;
                this.ram = ram;
                this.storage = storage;
                this.screenSize = screenSize;
            }
            public void sfullINfo()
            {
                Console.WriteLine("Ваш процессор " + CPU);
                Console.WriteLine("Обьем оперативной памяти" + ram);
                Console.WriteLine("Обьем постоянной памяти" + storage);
                Console.WriteLine("Диагональ экрана" + screenSize);

            }
        }
        class Printer : Device
        {
                public string type { get; set; }
                public string isColor { get; set; }
                public int speed { get; set; }
                public void powerOn()
            {
                if (isActive == 1)
                {
                    Console.WriteLine("Printer is ready");

                }
                else
                {
                    Console.WriteLine("Printer is off");
                }
            }
            public Printer()
            {
                type = "unknown";
                isColor = "unknown";
                speed = 0;
            }
            public Printer(string type,string isColor,int speed)
            {
                this.type = type;
                this.isColor = isColor;
                this.speed = speed;
            }
            public void FullInfo()
            {
                Console.WriteLine("Тип принтера " + type);
                Console.WriteLine("Цветной ли принтер" + isColor);
                Console.WriteLine("Скорость печати" + speed);
            }
           
        }   
        static void Main(string[] args)
        {
            SmartPhone smartphone = new SmartPhone();
            Console.WriteLine("Ваш девайс активен? 0-нет,1-да");
            smartphone.DeviceStatus = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите производителя девайса :");
            smartphone.Manufacturer = Console.ReadLine();
            Console.WriteLine("Введите модель девайса");
            smartphone.Model = Console.ReadLine();
            smartphone.fullInfo();
            smartphone.DeviceS();
            Console.WriteLine("Описание процессора : ");
            smartphone.CPU = Console.ReadLine();
            Console.WriteLine("Обьем оперативной памяти : ");
            smartphone.ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Обьем постоянной памяти : ");
            smartphone.storage = int.Parse(Console.ReadLine());
            Console.WriteLine("Разрешение экрана");
            smartphone.screenSize = Console.ReadLine();
            smartphone.sfullINfo();
            smartphone.powerOn();
            Printer printer = new Printer();
            Console.WriteLine("Введите тип принтера : ");
            printer.type = Console.ReadLine();
            Console.WriteLine("Формат принтера : ");
            printer.isColor = Console.ReadLine();
            Console.WriteLine("Введите скорость печати принтера : ");
            printer.speed = int.Parse(Console.ReadLine());
            printer.PowerOn();
        }
    }
}
