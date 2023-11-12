using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeConstruction
{
    // Класс дома
    class House
    {
        private List<IPart> parts;
        private int currentPartIndex;

        public List<IPart> Parts => parts;
        public int CurrentPartIndex => currentPartIndex;

        public House()
        {
            parts = new List<IPart>
            {
                new Basement(),
                new Walls(), new Walls(), new Walls(), new Walls(),
                new Door(),
                new Window(), new Window(), new Window(), new Window(),
                new Roof()
            };
            currentPartIndex = -1;
        }

        public IPart GetCurrentPart()
        {
            if (currentPartIndex >= 0 && currentPartIndex < parts.Count)
            {
                return parts[currentPartIndex];
            }
            return null;
        }

        public void BuildNextPart()
        {
            if (currentPartIndex < parts.Count - 1)
            {
                currentPartIndex++;
            }
        }
    }

}
