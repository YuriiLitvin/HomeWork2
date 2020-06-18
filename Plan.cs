using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    //TODO: you create plan just to have external call to ".GetSpecification"
    //TODO: create a Specification field and fill it within constructor once.
    class Plan
    {
        //public List<IPart> Specification;
        //public Plan(List<IPart> specification)
        //{
        //    Specification = specification;
        //}

        private Dictionary<Type, int> GetHousePartTypesWithIndexes()
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

        // DONE: return List<IPart> here; List already has index!
        
        public List<IPart> GetSpecification()
        {
            List<IPart> constructionList = this.GetConstructionList();
            
            return Randomizer<IPart>.GetRandomOrderList(constructionList);
        }

        private List<IPart> GetConstructionList()
        {

            var housePartTypes = this.GetHousePartTypesWithIndexes()
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

        private List<IPart> GetParts(Type partType, int partCount)
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
