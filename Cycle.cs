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
            int exitValue = 7;
            int stepValue = 7;
            int maximumNumber = 98;

            for (int i = exitValue; exitValue <= maximumNumber ; exitValue += stepValue )
            {
                 Console.Write(exitValue+" ");
            }
        }
    }
}
