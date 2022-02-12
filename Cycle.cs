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
            
            for(int i = 0; i < 14 ; i++)
            {
                Console.Write(exitValue+" ");
                exitValue += stepValue;
            }
        }
    }
}
