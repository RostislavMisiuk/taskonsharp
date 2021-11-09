using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    interface IWorker
    {
        string Name { get; }
    }
    interface IPart
    {
        void Do(House house);
    }

    class Basement : IPart
    {
        public void Do(House house)
        {
            house.basement = new Basement();
        }
    }

    class Walls : IPart
    {
        public void Do(House house)
        {
            house.walls.Add(new Walls());
        }
    }

    class Door : IPart
    {
        public void Do(House house)
        {
            house.door = new Door();
        }
    }

    class Window : IPart
    {
        public void Do(House house)
        {
            house.window.Add(new Window());
        }
    }

    class Roof : IPart
    {
        public void Do(House house)
        {
            house.roof = new Roof();
        }
    }

    class House
    {
        public Basement basement;
        public List<Walls> walls;
        public List<Window> window;
        public Door door;
        public Roof roof;

        public void Paint(TeamLeader t)
        {
            if (t.report.Count == 11)
            {

                string domik = @"
______8_________8_________8
______88_______888________88
_____88_________8________88
______8_________8_________8
_____888_______888_______888
____88888_____88888_____88888
___8888888___8888888___8888888
__888888888_888888888_888888888
__888888888_888888888_888888888
___8888888___8888888___8888888
__88888888888888888888888888888
__88888888888888888888888888888
__88888888888888888888888888888
__8888_____88888888888_____8888
__8888__8__88888888888__8__8888
__8888__8__88888888888__8__8888
__8888_____88888888888_____8888
__88888888888888888888888888888
__88888888888888888888888888888
__88888888888888888888888888888
__888888888888_____888888888888
__888888888888_____888888888888
__888888888888__8__888888888888
__888888888888_____888888888888";

                Console.WriteLine(domik);
            }
            else Console.WriteLine("The house is not built yet");
        }
    }

    class Team : IWorker
    {
        public TeamLeader t;
        public List<Worker> w;
        public string Name { get => "KharkivBudSTROY"; }

        public Team()
        {
            t = new TeamLeader("Vyacheslav");
            w = new List<Worker> { new Worker("Dmitry"), new Worker("Valeriy"), new Worker("Andrey"), new Worker("Maksim") };
        }


    }

    class Worker : IWorker
    {
        string Name { get; set; }

        string IWorker.Name => Name;

        public Worker(string name)
        { Name = name; }

        public void Build(House house, TeamLeader t)
        {
            if (house.basement == null)
            {
                Basement basement = new Basement();
                basement.Do(house);
                t.report.Add($"Worker {Name} builded is basement!");
            }
            else if (house.walls == null || house.walls.Count < 4)
            {
                if (house.walls == null) house.walls = new List<Walls>();
                Walls wall = new Walls();
                wall.Do(house);
                t.report.Add($"Worker {Name} builded is wall {house.walls.Count}!");
            }
            else if (house.door == null)
            {
                Door door = new Door();
                door.Do(house);
                t.report.Add($"Worker {Name} builded is door!");

            }

            else if (house.window == null || house.window.Count < 4)
            {
                if (house.window == null) house.window = new List<Window>();
                Window window = new Window();
                window.Do(house);
                t.report.Add($"Worker {Name} builded is window {house.window.Count}!");

            }

            else if (house.roof == null)
            {
                Roof roof = new Roof();
                roof.Do(house);
                t.report.Add($"Worker {Name} builded is roof!");

            }

        }



    }

    class TeamLeader : IWorker
    {
        string Name { get; set; }
        public List<string> report = new List<string>();
        string IWorker.Name => Name;

        public TeamLeader(string name)
        { Name = name; }
        public void Report()
        {
            double d = (report.Count / 11.0) * 100;
            Console.WriteLine($"{(int)d} % of work completed!");
        }
    }

    class Program
    {
        static void Main()
        {
            House house = new House();
            Team team = new Team();

            Console.WriteLine(team.Name);

            Random r = new Random();

            for (int i = 0; i < 6; i++)
            {
                team.w[r.Next(0, 3)].Build(house, team.t);
            }

            foreach (var a in team.t.report)
            {
                Console.WriteLine(a);
            }

            team.t.Report();
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                team.w[r.Next(0, 3)].Build(house, team.t);
            }

            foreach (var a in team.t.report)
            {
                Console.WriteLine(a);
            }
            team.t.Report();

            house.Paint(team.t);
            Console.ReadKey();
        }
    }
}

