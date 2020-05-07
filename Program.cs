using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Builder builder = new Builder();
            //builder.DoWork();
            Team myTeam = new Team(1,2);

            //for (int i = 0; i < myTeam.GetBuilders().Count; i++)
            //{
            //    Console.WriteLine($"{builder.Name} {builder.Position}");
            //    builder.DoWork();
            //}
            

            foreach (var builder in myTeam.GetBuilders())
            {
                Console.WriteLine($"{builder.Name} {builder.Position}");
                builder.DoWork();
            }


            Console.ReadKey();
        }
    }
}
