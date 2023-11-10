using System;
using System.Collections.Generic;

namespace LargeElementArray
{
        class Program
        {
            static void Main()
            {
                int sizeArrayLines = 10;
                int sizeArrayColumns = 10;
                int [,] matrix = new int[sizeArrayLines,sizeArrayColumns];
                int maximumElement = int.MinValue;
                Random random = new Random();

                Console.WriteLine("Исходная матрица");
                    
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = random.Next(1, 11);

                        if (matrix[i, j] > maximumElement)
                        {
                            maximumElement = matrix[i, j];
                        }
                            
                        Console.Write(matrix[i,j] + " ");
                    }
                        
                    Console.WriteLine();
                }
                    
                Console.WriteLine("Наибольший элемент = " + maximumElement);

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if(matrix[i,j] == maximumElement)
                        {
                            matrix[i, j] = 0; 
                        }
                    }
                }
                    
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
