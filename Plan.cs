using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Plan
    {
        public Dictionary<Type, int> GetHousePartTypesWithIndexes()
        {
            Dictionary<Type, int> PartTypesWithIndexes = new Dictionary<Type, int>
            {
                { typeof(Roof), 4 },
                { typeof(Door), 2 },
                { typeof(Basement), 0 },
                { typeof(Window), 3 },
                { typeof(Wall), 1 }
            };
            return PartTypesWithIndexes;
        }

        public List<IPart> GetConstructionPlan()
        {
            Plan myPlan = new Plan();

            var housePartTypes = myPlan.GetHousePartTypesWithIndexes()
                .OrderBy(_ => _.Value)
                .Select(_ => _.Key);

            List<IPart> constructionList = new List<IPart>();
            foreach (var part in housePartTypes)
            {
                Console.WriteLine($"Please enter a number of {part.Name}s");
                var partCount = Convert.ToInt32(Console.ReadLine());
                foreach (var item in GetParts(part, partCount))
                {
                    constructionList.Add(item);
                }
            }

            List<IPart> constructionPlan = constructionList.ToList();

            return constructionPlan;
        }

        public List<IPart> GetParts(Type partType, int partCount)
        {
            List<IPart> parts = new List<IPart>();

            for (int i = 1; i <= partCount; i++)
            {
                IPart createdPart = CreatePart(partType);

                createdPart.Name = partType.Name + i;
                createdPart.IsDone = false;
                parts.Add(createdPart);
            }
            return parts;
        }

        private IPart CreatePart(Type partType)
        {
            return Activator.CreateInstance(partType) as IPart;
        }
    }
}
