using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi comanda, ime, nomer: ");
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                string name = tokens[1];

                if (command == "A")
                {
                    string phone = tokens[2];
                    phoneBook[name] = phone;
                }
                else if (command == "S")
                {
                    if (phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phoneBook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contacta {name} ne sasthestvuva!");
                    }
                }
            }
        }
    }
}
