using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class TeamLeader : IWorker
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Energy { get; set; } 

        //TODO: eliminate 3 pairs of {}
        public bool DoWork(Dictionary<int, IPart> specification, int partIndex)
        {
            float totalPercent = 0.0f;
            float partPercent = 100.0f / (float)specification.Count;
            if (this.Energy >= 80)
            {

                foreach (KeyValuePair<int, IPart> pair in specification)
                {
                    if (pair.Value.IsDone)
                    {
                        Console.WriteLine($"{pair.Value.Name} completed");
                        totalPercent += partPercent;
                    }
                }
                Energy = GetEnergyLevel(true);
                Console.WriteLine($"Construction completed: {totalPercent}%\n");


                return specification.All(pair => pair.Value.IsDone == true);  
            }
            else
            {
                Console.WriteLine("I can't work now. I need day off");
                this.Energy = GetEnergyLevel(false);

            }
            return false;
        }
        //TODO:  Don't repeat youself 
        public int GetEnergyLevel(bool resultOfWork)
        {
            Random random = new Random();
            if (resultOfWork)
            {
                this.Energy -= random.Next(10, 20);
            }
            else
            {
                this.Energy += random.Next(5, 15);
            }
            return Energy;
        }

    }
}
