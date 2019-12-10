using System;

namespace CyclomaticComplexity
{
    // CC = 1
    public class IfStatements
    {
        // CC = 1
        public string Process(DateTime dt)
        {
            // CC = 1
            Console.WriteLine("Processing...");

            var result = "";

            // CC = 2
            if (dt.Year < DateTime.Today.Year)
                //if (dt.Year == 2018)
                    result = "Past";      // && dt.Year == 2018 || dt.Year == 2017

            // CC = 3
            else if (dt.Year == DateTime.Today.Year) { result = "Present"; }

            // CC = 3 (cause will be executed as an alternative to the preceding "if condition" which is already CC profiled)
            else { result = "Future"; }

            return result;
        }
    }
}
