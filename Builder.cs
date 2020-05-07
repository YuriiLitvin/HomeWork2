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

        public void DoWork()
        {
            Plan myPlan = new Plan();

            foreach (var part in myPlan.GetConstruction())
            {
                //int indexOfPart = myPlan.GetListOfParts().IndexOf(part);
                //bool status = myPlan.GetListOfParts()[indexOfPart].CheckIfDone();

                //if (status)
                //{
                //    Console.WriteLine($"{part.Name} is finished");
                //}
                //else
                //{
                    for (int i = 0; i < part.PartCount; i++)
                    {
                        Console.WriteLine($"I start making {part.Name}#{i+1}");
                        //part.IsDone = true;
                    }

                //}


            }

            //Console.ReadKey();

        }
    }
}
