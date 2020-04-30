using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Team
    {
        public int TeamLeaderCount { get; set; }
        public int BuilderCount { get; set; }
        
        public Team(string teamLeader, string builderCount) 
        {
            TeamLeaderCount = Convert.ToInt32(teamLeader);
            BuilderCount = Convert.ToInt32(builderCount);
        }
    }
}
