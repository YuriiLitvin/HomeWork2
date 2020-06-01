using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    public class Randomizer<T>
    {
        public Dictionary<int,T> Get(List<T> list)
        {
            Random rand = new Random();
            
            Dictionary<int, T> withInOrder = new Dictionary<int, T>();
            for (int indexT = 0; indexT < list.Count; indexT++)
            {
                withInOrder.Add(indexT, list[indexT]);
            }

            Dictionary<int, T> withOutOrder = new Dictionary<int, T>();
            
            while (withOutOrder.Count < withInOrder.Count)
            {
                int randomIndex = rand.Next(0, list.Count);

                if (!withOutOrder.ContainsKey(randomIndex))
                {
                    withOutOrder.Add(randomIndex, withInOrder[randomIndex]);
                }
            }
            return withOutOrder;
        }
    }
}
