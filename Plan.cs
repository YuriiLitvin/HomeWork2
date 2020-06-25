namespace BuildingHouse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Plan
    {
        public Dictionary<int, IPart> Specification { get; }

        public Dictionary<Type,int> PartTypesWithIndexes { get; set; }
        public Plan()
        {
            this.Specification = this.GetSpecification();
            this.PartTypesWithIndexes = this.GetHousePartTypesWithIndexes();
        }

        public Dictionary<Type, int> GetHousePartTypesWithIndexes()
        {
            var partTypesWithIndexes = new Dictionary<Type, int>
            {
                { typeof(Roof), 4 },
                { typeof(Door), 2 },
                { typeof(Basement), 0 },
                { typeof(Window), 3 },
                { typeof(Wall), 1 },
            };
            return partTypesWithIndexes;
        }

        // return List<IPart> here; List already has index!
        // randomize another way e.g. newList[0] = oldList[random];
        public Dictionary<int, IPart> GetSpecification()
        {
            var constructionList = this.GetConstructionList();

            return Randomizer<IPart>.GetUnsorted(constructionList);
        }

        private List<IPart> GetConstructionList()
        {
            var housePartTypes = this.GetHousePartTypesWithIndexes()
                .OrderBy(_ => _.Value)
                .Select(_ => _.Key);

            var constructionList = new List<IPart>();
            foreach (var part in housePartTypes)
            {
                Console.WriteLine($"Please enter a number of {part.Name}s");
                var partCount = Convert.ToInt32(Console.ReadLine());
                foreach (var item in this.GetParts(part, partCount))
                {
                    constructionList.Add(item);
                }
            }

            return constructionList;
        }

        private List<IPart> GetParts(Type partType, int partCount)
        {
            var parts = new List<IPart>();

            for (int i = 1; i <= partCount; i++)
            {
                var createdPart = this.CreatePart(partType);

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
