using System;
using System.Collections.Generic;

namespace BuildingHouse
{
    public static class Randomizer<T>
    {
        public static List<T> GetUnsorted(List<T> list)
        {
            //TODO: do something with Random
            Random rand = new Random();

            //Dictionary<int, T> ordered = new Dictionary<int, T>();
            //for (int indexT = 0; indexT < list.Count; indexT++)
            //{
            //    ordered.Add(indexT, list[indexT]);
            //}

            //Dictionary<int, T> disordered = new Dictionary<int, T>();

            //while (disordered.Count < ordered.Count)
            //{
            //    int randomIndex = rand.Next(0, list.Count);

            //    if (!disordered.ContainsKey(randomIndex))
            //    {
            //        disordered.Add(randomIndex, ordered[randomIndex]);
            //    }
            //}
            //return disordered;

            List<T> disorderedList = new List<T>();

            for (int index = 0; index < list.Count;)
            {
                int randomIndex = rand.Next(0, list.Count);
                if (!disorderedList.Contains(list[randomIndex]))
                {
                    disorderedList[index] = list[randomIndex];
                    index++;
                }
            }
            return disorderedList;
        }
    }
}
