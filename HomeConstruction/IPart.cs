using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeConstruction
{
    interface IPart
    {
        void Build();
    }

    // Классы частей дома
    class Basement : IPart
    {
        public void Build()
        {
            Console.WriteLine("Фундамент построен");
        }
    }

    class Walls : IPart
    {
        public void Build()
        {
            Console.WriteLine("Стена построена");
        }
    }

    class Door : IPart
    {
        public void Build()
        {
            Console.WriteLine("Дверь установлена");
        }
    }

    class Window : IPart
    {
        public void Build()
        {
            Console.WriteLine("Окно установлено");
        }
    }

    class Roof : IPart
    {
        public void Build()
        {
            Console.WriteLine("Крыша установлена");
        }
    }
}
