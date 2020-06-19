using System;
using System.Collections.Generic;

namespace BuildingHouse
{
    public abstract class Worker : IWorker, IEnergyManagable
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public EnergyManager EnergyManager { get; set; } = new EnergyManager();

        public abstract bool DoWork(Dictionary<int, IPart> specification, int partIndex);

        public void GetDayOff() => Console.WriteLine("I can't work now. I need day off");

        public void GetNameAndPosition() => Console.WriteLine($"\n{Name} " +
                      $"{Position}");
        
        public bool TryDoWork(Dictionary<int, IPart> specification, int partIndex)
        {

            GetNameAndPosition();
            
            if(EnergyManager.CanDoWork())
            {
                EnergyManager.Decrease();
                return DoWork(specification, partIndex);
            }
            else
            {
                GetDayOff();
                EnergyManager.Increase();
            }
            return false;
        }
    }
}
