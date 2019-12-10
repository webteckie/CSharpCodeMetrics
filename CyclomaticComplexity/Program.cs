using System;

namespace CyclomaticComplexity
{
    // CC = 1
    class Program
    {
        // CC = 1 (because it doesn't introduce a new flow path)
        static void Main(string[] args)
        {
            // CC = 1 (because it doesn't introduce a new flow path)
            Console.WriteLine("Hello...");
            Console.WriteLine("World!");
        }
    }
}
