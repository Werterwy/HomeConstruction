using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeConstruction
{
    class Team
    {
        private List<IWorker> workers = new List<IWorker>();

        public void AddWorker(IWorker worker)
        {
            workers.Add(worker);
        }

        public void WorkOnHouse(House house)
        {
            Console.WriteLine("Бригада начинает строительство дома:");

            foreach (var worker in workers)
            {
                var currentPart = house.GetCurrentPart();
                if (currentPart != null)
                {
                    worker.Work(currentPart);
                    house.BuildNextPart();
                }
                else
                {
                    Console.WriteLine("Весь дом уже построен!");
                    break;
                }
            }

            Console.WriteLine("Строительство дома завершено.");
        }
    }
}
