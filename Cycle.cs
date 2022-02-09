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
            int numberOnIncrease = 7;
            int lenghtArray = 14;
            int numberExit = 7;
            
            for(int i=0; i < lenghtArray; i++)
            {
                Console.WriteLine(numberExit);
                numberExit += numberOnIncrease;
            }
        }
    }
}
