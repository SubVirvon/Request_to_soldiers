using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Request_to_soldiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller(new Warrior[]
            {
                new Warrior("Иван", "винтовка", "сержант", 2)
            });

            controller.ShowResult();

            Console.ReadKey();
        }
    }

    class Controller
    {
        private Warrior[] _warriors;

        public Controller(Warrior[] warriors)
        {
            _warriors = warriors;
        }

        public void ShowResult()
        {
            var newWarriors = from Warrior warrior in _warriors
                         select new
                         {
                             Name = warrior.Name,
                             Rank = warrior.Rank,
                         };

            foreach(var warrior in newWarriors)
            {
                Console.WriteLine($"{warrior.Name} - {warrior.Rank}");
            }
        }
    }

    class Warrior
    {
        public string Name { get; private set; }
        public string Weapon { get; private set; }
        public string Rank { get; private set; }
        public int ServiseTime { get; private set; }

        public Warrior(string name, string weapon, string rank, int serviseTime)
        {
            Name = name;
            Weapon = weapon;
            Rank = rank;
            ServiseTime = serviseTime;
        }
    }
}
