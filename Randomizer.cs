using System;
using System.Collections.Generic;


namespace BuildingHouse
{
    //DONE: make it static
    // DONE: randomize another way e.g. newList[0] = oldList[random];
    public static class Randomizer<T>
    {
        public static List<T> GetRandomOrderList(List<T> list)
        {
            Random rand = new Random();

            List<T> disorderedList = new List<T>();
            
            for(int index = 0; index < list.Count;)
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
