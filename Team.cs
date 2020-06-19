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
            Dictionary<int,Worker> workers = personnel.CreateTeam();
            Dictionary<int, IPart> specification = myPlan.GetSpecification();
            
            int partToDoIndex = 0;
            while (partToDoIndex < specification.Count) 
            {
                foreach (KeyValuePair<int, Worker> worker in workers)
                {
                    bool isDone = worker.Value.TryDoWork(specification, partToDoIndex);

                    if (isDone) partToDoIndex++;
                }
            }       
        }
        
        
    
    
    }
}
