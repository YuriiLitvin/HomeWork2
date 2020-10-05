using System;
using System.Collections.Generic;

namespace BuildingHouse
{
    public static class Randomizer<T>
    {
        public static List<T> GetDisordered(List<T> list)
        {
            //TODO: do something with Random
            Random rand = new Random();

            List<T> disorderedList = new List<T>();

            while (disorderedList.Count < list.Count)
            {
                int randomIndex = rand.Next(0, list.Count);
                if (!disorderedList.Contains(list[randomIndex]))
                {
                    disorderedList.Add(list[randomIndex]);
                }
            }
            return disorderedList;
        }
    }
}
