using System;


namespace BuildingHouse
{
    public class EnergyManager
    {
        private int Energy;

        private const int minEnergyLevel = 80;
        private const int maxEnergyLevel = 100;
        private const int increaseMin = 5;
        private const int increaseMax = 15;
        private const int decreaseMin = 10;
        private const int decreaseMax = 20;

        private static readonly Random random = new Random();

        public EnergyManager()
        {
            this.GetInitialEnergyLevel();
        }

        public bool CanDoWork()
        {
           return Energy >= minEnergyLevel;
        }
        public void GetInitialEnergyLevel() => Energy = random.Next(minEnergyLevel, maxEnergyLevel);
        public void Increase() => Energy += random.Next(increaseMin, increaseMax);
        public void Decrease() => Energy -= random.Next(decreaseMin, decreaseMax);




    }
}
