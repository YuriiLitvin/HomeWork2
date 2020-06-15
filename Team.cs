using System;
using System.Collections.Generic;
using System.Linq;


namespace BuildingHouse
{
    class Team
    {
        
        public void GetToWork(Plan myPlan, TeamCreater personnel)
        {
            Dictionary<int,IWorker> workers = personnel.CreateTeam();
            Dictionary<int, IPart> specification = myPlan.GetSpecification();
            
            int partToDoIndex = 0;
            int minEnergyLevel = 80;
            while (partToDoIndex < specification.Count) 
            {
                foreach (KeyValuePair<int, IWorker> worker in workers)
                {
                    Console.WriteLine($"\n{worker.Value.Name} " +
                      $"{worker.Value.Position}");
                    
                    bool isDone = (worker.Value.Energy >= minEnergyLevel) ?
                        worker.Value.DoWork(specification, partToDoIndex) : worker.Value.GetDayOff();
                    
                    worker.Value.Energy = EnergySetter.SetEnergyLevel(isDone, worker.Value.Energy);
                    
                    if (isDone) partToDoIndex++;
                }
            }       
        }
        
        
    
    
    }
}
