using System;

namespace ClassCoupling
{
    // CC = 0; a class definition on its own represents a single task so no class coupling exist, yet
    class Program
    {
        static void Main(string[] args)
        {
            // Console is a class so CC = 1
            //Console.WriteLine("Hello...");
            //Console.WriteLine("World!");

            // Adds the cumulative CCs from each class
            //var worker = new Worker(new Dependency());
        }

        //static Exception test() { ; }
    }
}
