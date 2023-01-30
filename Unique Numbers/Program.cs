using System;
using System.Linq;

namespace Unique_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter 5 unique integers seperated by a hyphen: ");
                var input = Console.ReadLine();
                if (input == "")
                {
                    Console.WriteLine("Please Retry.");
                    break;
                }

                var numbers = Array.ConvertAll(input.Split('-'), int.Parse).ToList();
                if (numbers.Count != numbers.Distinct().Count())
                {
                    Console.WriteLine("Duplicate.");
                    break;
                }
                else if (numbers.Count == numbers.Distinct().Count())
                {
                    Console.WriteLine("Not duplicate.");
                    break;
                }
            }
            
        }
    }
}
