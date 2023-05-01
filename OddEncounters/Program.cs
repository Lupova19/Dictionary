using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OddEncounters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi dumi, chisla ili znaci: ");
            string[] words = Console.ReadLine().ToLower().Split(' ').ToArray();
            Dictionary<string, int> statistics = new Dictionary<string, int>();
            foreach (string item in words) 
            { 
                if (statistics.ContainsKey(item))
                {
                    statistics[item] = statistics[item] + 1;
                }
                else
                {
                    statistics.Add(item, 1);
                }
            }
            foreach (var item in statistics) 
            {
                Console.WriteLine($"{item} -> {item.Value}");
            }
        }
    }
}
