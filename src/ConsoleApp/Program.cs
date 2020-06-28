using Newtonsoft.Json;
using System;

namespace ConsoleApp
{
    class Program
    {   //Base branch
        static void Main(string[] args)
        {
            var package = new Package
            {
                Name = "Newtonsoft.json",
                Version = "12.0.3",
                Author = "Newtonsoft"
            };

            var json = JsonConvert.SerializeObject(package);

            Console.WriteLine(json);
        }
    }
}
