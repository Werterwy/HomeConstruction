using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeConstruction
{
    interface IWorker
    {
        void Work(IPart part);
    }

    // Классы для рабочих
    class Worker : IWorker
    {
        public void Work(IPart part)
        {
            part.Build();
        }
    }

    // Класс бригадира
    class TeamLeader : IWorker
    {
        public void Work(IPart part)
        {
            Console.WriteLine("Бригадир проверяет:");
            part.Build();
        }
    }

}
