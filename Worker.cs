using System;

namespace BuildingHouse
{
    public abstract class Worker : IWorker, IEnergyManagable
    {
        public string Name { get; set; }

        public string Position { get; set; }

        public EnergyManager EnergyManager { get; set; } = new EnergyManager();

        public abstract bool DoWork(Plan plan);

        public void GetDayOff() => Console.WriteLine("I can't work now. I need day off");

        public void DisplayNameAndPosition() => Console.WriteLine($"\n{this.Name} " +
                      $"{this.Position}");

        public bool TryDoWork(Plan plan)
        {

            this.DisplayNameAndPosition();

            if (this.EnergyManager.CanDoWork())
            {
                this.EnergyManager.Decrease();
                return this.DoWork(plan);
                
            }
            
            this.GetDayOff();
            this.EnergyManager.Increase();
            return false;
        }
    }
}
