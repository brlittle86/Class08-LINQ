using System;
using System.IO;
using System.Linq;

namespace LINQLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string deserializedJSON = GetJSONString();
        }

        static string GetJSONString()
        {
            using (StreamReader sr = File.OpenText("data.json"))
            {
                string[] json = File.ReadAllLines("data.json");
                return json[0];
            }
        }
    }
}
