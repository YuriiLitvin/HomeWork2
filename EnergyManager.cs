using System;


namespace BuildingHouse
{
    public class EnergyManager
    {
        private const int MinEnergyLevel = 80;
        private const int MaxEnergyLevel = 100;
        private const int IncreaseMin = 5;
        private const int IncreaseMax = 15;
        private const int DecreaseMin = 10;
        private const int DecreaseMax = 20;
        
        //TODO: do something with Random
        private static readonly Random Random = new Random();

        private int energy;

        public EnergyManager()
        {
            this.GetInitialEnergyLevel();
        }

        public bool CanDoWork()
        {
           return this.energy >= MinEnergyLevel;
        }

        public void GetInitialEnergyLevel() => this.energy = Random.Next(MinEnergyLevel, MaxEnergyLevel);

        public void Increase() => this.energy += Random.Next(IncreaseMin, IncreaseMax);

        public void Decrease() => this.energy -= Random.Next(DecreaseMin, DecreaseMax);
    }
}
