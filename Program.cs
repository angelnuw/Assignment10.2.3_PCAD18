using System;
using System.Linq;

namespace Assignment10._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA",
                                "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            Console.Write("input starting character for the string: ");
            char startChar = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.Write("Input ending character for the string: ");
            char endChar = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            var result = from city in cities
                         where city.StartsWith(startChar.ToString())
                                && city.EndsWith(endChar.ToString())
                         select city;

            if (result.Any())
            {
                foreach (var city in result)
                {
                    Console.WriteLine($"The city starting with {startChar} and ending with {endChar} is: {city}");
                }
            }
            else
            {
                Console.WriteLine($"No city found starting with {startChar} and ending with {endChar}");
            }
        }
    }
}
