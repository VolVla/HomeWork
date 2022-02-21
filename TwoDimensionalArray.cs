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
            int[,] arrayLine = { { 2,2,3,4 }, { 5,7,2,1 } };
            int sumLine = 0;
            int productColumn = 1;
            int numberLine = 1;
            int lineArray = 0;
            int columnArray = 0;
             
            for (int i = 0; i < arrayLine.GetLength(1); i++)
            {
                sumLine += arrayLine[numberLine,i ];
            }

            for (int j = 0; j < arrayLine.GetLength(0); j++ )
            {
              productColumn *= arrayLine[lineArray++, columnArray];
            }
            
            for (int i = 0; i < arrayLine.GetLength(0); i++)
            {
                for (int j = 0; j < arrayLine.GetLength(1); j++)
                {
                    Console.Write(arrayLine[i, j] + " ");
                }
                Console.WriteLine();
            } 
            Console.WriteLine(sumLine +" "+productColumn);
        }
    }
}
