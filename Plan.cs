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
       
        public Dictionary<int,IPart> GetSpecification()
        {
            List<IPart> constructionList = this.GetConstructionList();

            Dictionary<int, IPart> checkList = new Dictionary<int, IPart>();
            for (int partIndex = 0; partIndex < constructionList.Count; partIndex++)
            {
                checkList.Add(partIndex, constructionList[partIndex]);
            }



            Random rand = new Random();
            Dictionary<int, IPart> specification = new Dictionary<int, IPart>();
            while (specification.Count < checkList.Count)
            {
                int randomIndex = rand.Next(0, constructionList.Count);

                if (!specification.ContainsKey(randomIndex))
                {
                    specification.Add(randomIndex, checkList[randomIndex]);
                }

            }

            return specification;
        }



        public List<IPart> GetConstructionList()
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
            return constructionList;
            

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
