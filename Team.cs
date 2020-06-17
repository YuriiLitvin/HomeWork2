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
        
        public void GetConstructionDone(Plan myPlan, TeamCreator personnel)
        {
            List<IWorker> workers = personnel.CreateTeam();
            List<IPart> specification = myPlan.GetSpecification();
            
            int minEnergyLevel = 80;
            
            while (partToDoIndex < specification.Count) 
            {
                foreach (IWorker worker in workers)
                {
                    Console.WriteLine($"\n{worker.Name} " +
                      $"{worker.Position}");
                    bool isDone = worker.GetToWork(specification);
                    //bool isDone = (worker.Energy >= minEnergyLevel) ?
                    //    worker.DoWork(specification) : worker.GetDayOff();
                    
                    //worker.Energy = EnergySetter.SetEnergyLevel(isDone, worker.Energy);
                    
                    if (isDone) partToDoIndex++;
                }
            }       
        }
        
        
    
    
    }
}
