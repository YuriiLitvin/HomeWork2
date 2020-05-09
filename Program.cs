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

            //List<char> parts = new List<char> {  'a' ,  'b', 'c', 'd', 'e' , 'f', 'g', 'h', 'i', 'j', 'k' };
            //List<string> builders = new List<string> { "w1", "w2", "w3", "w4", "w5" };

            //for (int i = 0; i < parts.Count; i++)
            //{
            //    double j = i / builders.Count;
            //    int t = Convert.ToInt32(Math.Round(j, 0));
            //    Console.WriteLine($"{builders[i - t * builders.Count]} makes {parts[i]}");
            //}
            //Console.ReadKey();


            //Plan myPlan = new Plan();

            //Team myTeam = new Team(1, 3);
            //List<Builder> builders = myTeam.GetBuilders();
            //for (int i = 0; i < myPlan.GetConstruction().Count; i++)
            //{
            //    double j = i / builders.Count;
            //    int t = Convert.ToInt32(Math.Round(j, 0));
            //    Console.WriteLine($"{builders[i - t * builders.Count].Name} " +
            //        $"{builders[i - t * builders.Count].Position}");

            //    //builders[i - t * builders.Count].DoWork();

            //}
            Builder builder = new Builder();
            builder.DoWork();

            Console.ReadKey();
        }
    }
}
