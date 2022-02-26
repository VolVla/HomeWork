using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElement = new int[30];
            int leftValue = 0;
            int rightValue = 0;
            int number = 0;
            int maximum = 0;
            Random random = new Random();

            for(int i = 0; i < arrayElement.Length; i++)
            {
                arrayElement[i] = random.Next(1, 10);
                Console.Write(arrayElement[i] + " ");
            }
            Console.WriteLine("$");

            for(int i = 1; i < arrayElement.Length - 1  ; i++)
            {
               
                

               
                
                    
                    if (arrayElement[i-1] < arrayElement[i] && arrayElement[i + 1]  < arrayElement[i])
                    {
                    Console.Write(arrayElement[i] + " ");
                     
                    
                    }
               
                
                
                
                
                
                 
            }
        }
    }
}
