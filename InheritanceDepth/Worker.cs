using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDepth
{
    // A class on its own constitutes a node in the inheritance depth graph (so it's ID = 1)
    // Interfaces do not add to the DIT metric since these would be all implemented at class level...these would be more of a class coupling issue?
    /// <summary>
    /// BEFORE
    /// </summary>
    //class Worker : IWorker //Dependency2 // (Dependency2) //, IWorker, IDependency2
    //{
    //    //public Worker()
    //    //{
    //    //}
    //}


    // Do not reuse Dependency1 by inheritance, instead inject it
    /// <summary>
    /// AFTER
    /// </summary>
    class Worker : IWorker
    {
        public Worker(IDependency1 dependency1)
        {
        }
    }
}
