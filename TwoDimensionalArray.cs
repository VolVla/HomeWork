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
            int[,] arrayLine = { { 2,2,3 }, { 5,7,2 } };
            int sumLine2 = 0 ;
            int productColumn1 = 1;
            int result;
            int numberLine = 1;
            int lineArray = 0;
            int columnArray = 0;
            int initialValueArray = 0;

            for (int y = initialValueArray; y < arrayLine.GetLength(1); y++)
            {
              sumLine2 += arrayLine[numberLine, initialValueArray];
            }

            for (int x = initialValueArray; x < arrayLine.GetLength(0); x++ )
            {
              productColumn1 *= arrayLine[lineArray++, columnArray] ;
            }
            
            for (int i = initialValueArray; i < arrayLine.GetLength(0);i++)
            {
                for (int j = initialValueArray; j < arrayLine.GetLength(1);j++)
                {
                  Console.Write(arrayLine[i, j] + " ");
                }
                Console.WriteLine();
            } 
            result = sumLine2 + productColumn1;
            Console.WriteLine(result);
        }
    }
}
