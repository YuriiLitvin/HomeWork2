using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    // make it static
    public static class Randomizer<T>
    {
        public static Dictionary<int,T> GetUnsorted(List<T> list)
        {
            Random rand = new Random();
            
            Dictionary<int, T> ordered = new Dictionary<int, T>();
            for (int indexT = 0; indexT < list.Count; indexT++)
            {
                ordered.Add(indexT, list[indexT]);
            }

            Dictionary<int, T> disordered = new Dictionary<int, T>();
            
            while (disordered.Count < ordered.Count)
            {
                int randomIndex = rand.Next(0, list.Count);

                if (!disordered.ContainsKey(randomIndex))
                {
                    disordered.Add(randomIndex, ordered[randomIndex]);
                }
            }
            return disordered;
        }
    }
}
