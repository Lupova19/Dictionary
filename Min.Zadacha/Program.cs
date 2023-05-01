using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Min.Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi polezno izkopaemo, kolichestvo: ");
            Dictionary<string, long> input = new Dictionary<string, long>();
            string input1; 

            while ((input1 = Console.ReadLine()) != "Stop")
            {
                long quantity = long.Parse(Console.ReadLine());
                input.Add(input1, 0 );
                input[input1] += quantity;
            }
            foreach (var item in input)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
