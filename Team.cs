using System;
using System.Collections.Generic;
using System.Linq;


namespace BuildingHouse
{
    // team is nothing without personnel, and it should be inner property
    // this property could be set in the constructor and used internally
    // if you want to use TeamCreator -- do it, but here internally
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
                    
                    worker.Value.Energy = EnergyManager.SetEnergyLevel(isDone, worker.Value.Energy);
                    
                    if (isDone) partToDoIndex++;
                }
            }       
        }
        
        
    
    
    }
}
