﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Team
    {
        public int LeaderCount { get; set; }
        public int BuilderCount { get; set; }
        
        public Team(int leaderCount, int builderCount) 
        {
            //LeaderCount = Convert.ToInt32(leaderCount);
            //BuilderCount = Convert.ToInt32(builderCount);
            LeaderCount = leaderCount;
            BuilderCount = builderCount;
        }

        public List<IWorker> GetLeaders()
        {
            List<IWorker> leaders = new List<IWorker>();

            for (int leaderIndex = 1; leaderIndex <= LeaderCount; leaderIndex++)
            {
                leaders.Add(
                    new TeamLeader()
                    {
                        Name = "Tim #" + leaderIndex,
                        Position = "TeamLeader"
                    });
            }
            return leaders;
        }
        public List<IWorker> GetBuilders()
        {
            List<IWorker> builders = new List<IWorker>();

            for (int leaderIndex = 1; leaderIndex <= BuilderCount; leaderIndex++)
            {
                builders.Add(
                    new Builder()
                    {
                        Name = "Worker #" + leaderIndex,
                        Position = "Builder"
                    });
            }
            return builders;
        }

        //public List<IWorker> GetWorkers() => GetLeaders().Concat(GetBuilders()).ToList();

        public void GetToWork(Plan myPlan)
        {
            //List<IWorker> workers = this.GetWorkers();

            List<IPart> constructionPlan = myPlan.GetConstructionPlan();

            Random rand = new Random();
            
            
            Dictionary<int, string> constructionOrder = new Dictionary<int, string>();
            for (int partIndex = 0; partIndex < constructionPlan.Count; partIndex++)
            {
                constructionOrder.Add(partIndex,constructionPlan[partIndex].Name);
            }

            
            Dictionary<int, string> disorderedConstr = new Dictionary<int, string>();
            while (constructionOrder.Count!=disorderedConstr.Count)
            {
                int randomIndex = rand.Next(0, constructionPlan.Count);
                // constructionOrder will always have this key
                if (constructionOrder.ContainsKey(randomIndex)) 
                {
                    // add a value if there is already a value? add if there isn't :)
                    if (disorderedConstr.ContainsKey(randomIndex))
                    {
                        disorderedConstr.Add(randomIndex, constructionOrder[randomIndex]);
                    }
                    
                
                }
            }

            foreach (KeyValuePair<int, string> pair in disorderedConstr)
            {
                Console.WriteLine(pair);
            }








            //int partIndex = 0;
            //int builderIndex = 0;
            //while (partIndex < constructionPlan.Count)
            //{
            //    Console.WriteLine($"{workers[builderIndex].Name} " +
            //         $"{workers[builderIndex].Position}");

            //    var isDone = workers[builderIndex].DoWork(constructionPlan);

            //    if (isDone) partIndex++;

            //    builderIndex = (builderIndex + 1) % workers.Count;
            //}
            //for (int leaderIndex = 0; leaderIndex < LeaderCount; leaderIndex++)
            //{
            //    Console.WriteLine($"{workers[leaderIndex].Name} " +
            //         $"{workers[leaderIndex].Position}");
            //    workers[leaderIndex].DoWork(constructionPlan);
            //}

        }
    }
}
