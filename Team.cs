using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Team
    {
        public int LeaderCount { get; set; }
        public int BuilderCount { get; set; }
        
        public Team(string leaderCount, string builderCount) 
        {
            LeaderCount = Convert.ToInt32(leaderCount);
            BuilderCount = Convert.ToInt32(builderCount);
        }

        public List<TeamLeader> GetLeaders()
        {
            List<TeamLeader> builders = new List<TeamLeader>();

            for (int i = 0; i < LeaderCount; i++)
            {
                builders.Add(
                    new TeamLeader()
                    {
                        Name = "Tommy #" + i,
                        Position = "TeamLeader"
                    });
            }
            return builders;
        }
        public List<Builder> GetBuilders()
        {
            List<Builder> builders = new List<Builder>();

            for (int i = 0; i < BuilderCount; i++)
            {
                builders.Add(
                    new Builder()
                    {
                        Name = "Bobby #" + i,
                        Position = "Builder"
                    });
            }
            return builders;
        }
    

    
    
    
    
    
    }
}
