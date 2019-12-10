using System;
using System.Collections.Generic;
using System.Text;

namespace ClassCoupling
{
    // Every single class/interface dependency increments the Class Coupling metric
    class Worker : IWorker
    {
        // Injecting class adds 1CC per class injected
        //public Worker()
        public Worker(IDependency dependency, int foo)
        {
            Console.WriteLine("Console is a class :-)");
            var ex = new Exception();
        }
    }
}
