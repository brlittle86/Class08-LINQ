using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string json;
            using (StreamReader sr = File.OpenText("data.json"))
            {
                json = File.ReadAllText("data.json");
            }
            RootObject featuresCollection = JsonConvert.DeserializeObject<RootObject>(json);

            Console.WriteLine("Question 1: Display all neighborhoods.");
            var allFeatures = from o in featuresCollection.Features
                              where o.Properties.Neighborhood != null
                              select o;

            foreach (Feature item in allFeatures)
            {
                Console.WriteLine(item.Properties.Neighborhood);
            }
            Console.WriteLine();
            
            Console.WriteLine("Question 2: Remove blank Neighborhood entries.");
            var allNeighborhoods = allFeatures.Where(j => j.Properties.Neighborhood != "");
            foreach (Feature item in allNeighborhoods)
            {
                Console.WriteLine(item.Properties.Neighborhood);
            }
            Console.WriteLine();

            Console.WriteLine("Question 3: Remove duplicate Neighborhoods.");
            var uniqueNeighborhoods = allNeighborhoods.GroupBy(p => p.Properties.Neighborhood).Select(m => m.First());
            foreach (Feature item in uniqueNeighborhoods)
            {
                Console.WriteLine(item.Properties.Neighborhood);
            }
            Console.WriteLine();

            Console.WriteLine("Question 4: Do it all in one line.");
            var doItAll = featuresCollection.Features.Where(j => j.Properties.Neighborhood != "").GroupBy(p => p.Properties.Neighborhood).Select(m => m.First());
            foreach (Feature item in doItAll)
            {
                Console.WriteLine(item.Properties.Neighborhood);
            }
            Console.Read();
            
        }
    }
}
