namespace BuildingHouse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Plan
    {
        public List<IPart> Specification { get; }

        public Dictionary<Type, int> ConstructionOrderWithCounts = new Dictionary<Type, int>
        {
            { typeof(Basement),1},
            { typeof(Wall),4},
            { typeof(Door),1},
            { typeof(Window),4},
            { typeof(Roof),1}
        };

        public Plan()
        {
            this.Specification = this.CreateSpecification();
        }

        public List<IPart> CreateSpecification()
        {
            var constructionPlan = this.CreateConstructionPlan();

            return Randomizer<IPart>.GetDisordered(constructionPlan);
        }

        private List<IPart> CreateConstructionPlan()
        {
            var partTypes = ConstructionOrderWithCounts.Select(_ => _.Key);
            
            var constructionPlan = new List<IPart>();

            foreach (var partType in partTypes)
            {
                foreach (var part in this.CreateParts(partType))
                {
                    constructionPlan.Add(part);
                }
            }

            return constructionPlan;
        }

        private List<IPart> CreateParts(Type partType)
        {
            var createdParts = new List<IPart>();

            var partCount = ConstructionOrderWithCounts
                .Where(_ => _.Key == partType)
                .Select(_ => _.Value)
                .FirstOrDefault();

            for (int i = 1; i <= partCount; i++)
            {
                var createdPart = this.CreatePart(partType);

                createdPart.Name = partType.Name + i;
                createdPart.IsDone = false;
                createdParts.Add(createdPart);
            }

            return createdParts;
        }

        private IPart CreatePart(Type type)
        {
            return Activator.CreateInstance(type) as IPart;
        }
    }
}
