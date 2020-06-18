using System;


namespace BuildingHouse
{
    public class EnergyManager
    {
        public int Energy;

        public const int minEnergyLevel = 80;
        public const int maxEnergyLevel = 100;
        public const int increaseMin = 5;
        public const int increaseMax = 15;
        public const int decreaseMin = 10;
        public const int decreaseMax = 20;

        Random random = new Random();

        public bool CanDoWork()
        {
            if (Energy >= minEnergyLevel)
                return true;
            return false;
        }

        public int GetEnergyLevel() => Energy = random.Next(minEnergyLevel, maxEnergyLevel);

        public int Increase() => Energy += random.Next(increaseMin, increaseMax);
        public int Decrease() => Energy -= random.Next(decreaseMin, decreaseMax);



        public int SetEnergyLevel(bool isDone, int Energy)
        {
            // all randoms should be static;
            // in case you need to use random.Next(x, y) many times
            // make a wrapper in randomizer class

            if (isDone)
            {
                // 10 is increaseMin, 20 is increaseMax and they are constant!
                Energy -= random.Next(decreaseMin, decreaseMax);
            }
            else
            {
                // same here
                Energy += random.Next(increaseMin, increaseMax);
            }
            return Energy;
        }

    }
}
