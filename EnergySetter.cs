using System;


namespace BuildingHouse
{
    public static class EnergySetter
    {
        public static int SetEnergyLevel(bool isDone, int Energy)
        {
            Random random = new Random();
            if (isDone)
            {
                Energy -= random.Next(10, 20);
            }
            else
            {
                Energy += random.Next(5, 15);
            }
            return Energy;
        }

    }
}
