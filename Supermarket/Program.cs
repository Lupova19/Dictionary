using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi ime na product, cena, kolichestvo: ");
            Dictionary<string, double> prices = new Dictionary<string, double>();
            Dictionary<string, int> quantities = new Dictionary<string, int>();
            string[] input = Console.ReadLine().Split(' ');
            double totalSum = 0.0;

            while (input[0] != "Stocked")
            {
                if (!quantities.ContainsKey(input[0]))                
                {
                    quantities[input[0]] = 0;
                }

                prices[input[0]] = double.Parse(input[1]);
                quantities[input[0]] += int.Parse(input[2]);
                input = Console.ReadLine().Split(' ');
            }
            Console.WriteLine("-----------------------------------------");
            foreach (var item in prices)
            {
                
                Console.WriteLine($"{item.Key}: ${item.Value:F2} * {quantities[item.Key]} = ${item.Value * quantities[item.Key]:F2}");
                totalSum += item.Value * quantities[item.Key];
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Grand Total: ${totalSum:F2}");
        }
    }
}
