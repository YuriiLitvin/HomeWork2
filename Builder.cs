using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Builder : IWorker
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Energy { get; set; }

        public bool DoWork(Dictionary<int, IPart> specification, int partToDoIndex)
        {
            Random random = new Random();

            foreach (KeyValuePair<int, IPart> part in specification)
            {
                if (part.Key == partToDoIndex & !part.Value.IsDone)
                {
                    Console.WriteLine($"**************I completed {part.Value.Name}\n");
                    part.Value.IsDone = true;
                    this.Energy = random.Next(10,20);
                    return part.Value.IsDone;
                }
                else if (part.Value.IsDone)
                {

                }               
                else
                {
                    Console.WriteLine($"I can't do {part.Value.Name}" +
                        $" because {specification[partToDoIndex].Name} is not completed");
                    
                }

            }
            return false;
        }
    }
}
