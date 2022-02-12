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
            int maximumNumber = 99;

            for (; ; )
            {
                 Console.Write(exitValue+" ");
                 exitValue += stepValue;
                if (exitValue >= maximumNumber)
                {
                    break;
                }
            }
        }
    }
}
