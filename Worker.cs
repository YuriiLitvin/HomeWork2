using System;
using System.Collections.Generic;

namespace BuildingHouse
{
    public abstract class Worker : IWorker, IEnergyManagable
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public EnergyManager EnergyManager { get; set; }

        public abstract bool DoWork(Dictionary<int, IPart> specification, int partIndex);

        public bool GetDayOff()
        {
            Console.WriteLine("I can't work now. I need day off");
            return false;
        }

    }
}
