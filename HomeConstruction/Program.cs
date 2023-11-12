using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeConstruction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем объекты
            var house = new House();
            var team = new Team();
            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new TeamLeader());

            Console.WriteLine("Должно быть построено 1 фундамент, 4 стены, 1 дверь, 4 окна и 1 крыша");

            // Начинаем строительство
            team.WorkOnHouse(house);

            // Выводим отчет
            Console.WriteLine("\nОтчет о строительстве:");

            foreach (var part in house.Parts)
            {
                Console.WriteLine($"- {part.GetType().Name} построено");
            }

            Console.ReadLine();

        }
    }
}
