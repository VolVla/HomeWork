using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialValue = 0;
            int maximumValue = 14;
            int exitValue = 7;
            int stepValue = 7;
            
            for(int i = initialValue; i < maximumValue; i++)
            {
                Console.WriteLine(exitValue);
                exitValue += stepValue;
            }
        }
    }
}
