using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargeElementArray
{
        class Program
        {
            static void Main(string[] args)
            {
                int sizeArrayLines = 10;
                int sizeArrayColumns = 10;
                int [,] matrix = new int[sizeArrayLines,sizeArrayColumns];
                int lineMaximumElement = 0;
                int columnMaximumElement = 0;
                int maximumElement = matrix[lineMaximumElement, columnMaximumElement];
                Random random = new Random();

                matrix[1, 5] = random.Next(1, 11);
                
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] > maximumElement)
                        {
                           lineMaximumElement = i;
                           columnMaximumElement = j;
                           maximumElement = matrix[lineMaximumElement, columnMaximumElement];
                        }
                    }   
                }  
                Console.WriteLine("Наибольший элемент = " + maximumElement);
                Console.WriteLine("Исходная матрица");

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i,j] + " ");
                    }
                    Console.WriteLine();
                }
                matrix[lineMaximumElement, columnMaximumElement] = 0;
                Console.WriteLine("\nПолученная матрица");

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
}
