using System;


namespace BuildingHouse
{
    public static class EnergyManager
    {
        public static int SetEnergyLevel(bool isDone, int Energy)
        {
            // all randoms should be static;
            // in case you need to use random.Next(x, y) many times
            // make a wrapper in randomizer class
            Random random = new Random();
            if (isDone)
            {
                // 10 is increaseMin, 20 is increaseMax and they are constant!
                Energy -= random.Next(10, 20);
            }
            else
            {
                // same here
                Energy += random.Next(5, 15);
            }
            return Energy;
        }

    }
}
