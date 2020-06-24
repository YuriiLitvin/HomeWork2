using System;
using System.Collections.Generic;

namespace BuildingHouse
{
    public abstract class Worker : IWorker, IEnergyManagable
    {
        public string Name { get; set; }

        public string Position { get; set; }

        public EnergyManager EnergyManager { get; set; } = new EnergyManager();

        public abstract bool DoWork(Dictionary<int, IPart> specification);

        public void GetDayOff() => Console.WriteLine("I can't work now. I need day off");

        public void GetNameAndPosition() => Console.WriteLine($"\n{this.Name} " +
                      $"{this.Position}");

        public bool TryDoWork(Dictionary<int, IPart> specification)
        {

            this.GetNameAndPosition();

            if (this.EnergyManager.CanDoWork())
            {
                this.EnergyManager.Decrease();
                return this.DoWork(specification);
            }
            else
            {
                this.GetDayOff();
                this.EnergyManager.Increase();
            }

            return false;
        }
    }
}
