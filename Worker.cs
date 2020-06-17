using System;
using System.Collections.Generic;


namespace BuildingHouse
{
    public abstract class Worker : IWorker, IEnergyManagable
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Energy { get ; set; }

        public bool GetToWork(List<IPart> list)
        {
           
        }
        
        // it should be a void
        public bool GetDayOff()
        {
            Console.WriteLine("I can't work now. I need day off");
            return false;
        }

        public int GetEnergyLevel()
        {
            throw new NotImplementedException();
        }

        public int SetEnergyLevel()
        {
            throw new NotImplementedException();
        }
    }
}
