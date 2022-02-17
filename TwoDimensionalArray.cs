using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayLine = { { 1,2,3 }, { 5,7,2 } };
            int sumLine2 = 0 ;
            int productColumn1 = 0;
            int result;
            
            for (int y = 0; y < arrayLine.GetLength(0); y++)
            {
                sumLine2 = arrayLine[1,0] + arrayLine[1,1] + arrayLine[1,2];
                
                for (int x = 0; x < arrayLine.GetLength(1);x++ )
                {
                    productColumn1 = arrayLine[0, 0] * arrayLine[0, 1] * arrayLine[0, 2];
                    Console.Write(arrayLine[y, x] + " ");
                }
                Console.WriteLine();
            }
            result = sumLine2 + productColumn1;
            Console.WriteLine(result);
        }
    }
}
