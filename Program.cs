using System;
using System.Linq;

namespace VsCodeNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Please enter any number:");
            int n = Convert.ToInt32(Console.ReadLine());        
            Console.WriteLine($"Sum of bits in {n}:");
            Console.WriteLine(program.GetPopulationCount(n));
        }
        public int GetPopulationCount(int number)
        {
            return Convert.ToString(number,2).ToCharArray().Sum(c => Convert.ToInt32(c.ToString()));
        }
    }
}
