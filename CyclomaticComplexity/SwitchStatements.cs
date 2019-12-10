// Switch statements add an extra CC per case
using System;

namespace CyclomaticComplexity
{
    // CC = 1
    public class SwitchStatements
    {
        // CC = 1
        public string Process(DateTime dt)
        {
            // CC = 1
            Console.WriteLine("Processing...");

            var result = "";

            // CC = 1
            switch (dt.Year)
            {
                //    CC = 2
                case 2018:
                    result = "Past";
                    break;

                //    CC = 3
                case 2019:
                    result = "Present";
                    break;

                //    CC = 4
                default:
                    result = "Future";
                    break;
            }

            return result;
        }
    }
}
