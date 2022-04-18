using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenghtSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            const int AmountNumbers = 30;
            int[] arrayNumbers = new int[AmountNumbers] { 2, 3, 2, 2, 5, 2, 2, 2, 7, 7, 7, 7, 7, 7, 2, 1, 1, 1, 1, 1, 1, 1, 4, 1, 1, 1, 2, 2, 3, 3};
            int maximumValue = arrayNumbers[0];
            int maximumValueRepeat = 0;
            int numberRepeat = 1;

           for(int i = 0; i < arrayNumbers.Length - 1; i++)
           {
                if(arrayNumbers[i] == arrayNumbers[i + 1])
                {
                    numberRepeat++;
                    if (numberRepeat > maximumValueRepeat)
                    {
                        maximumValueRepeat = numberRepeat;
                        maximumValue = arrayNumbers[i];
                    }  
                }
                else if (arrayNumbers[i] != arrayNumbers[i + 1])
                {
                    numberRepeat = 1;
                }
           }
           Console.WriteLine($"\nСамое большое число {maximumValue}, кол-во повторений {maximumValueRepeat}");

           foreach (int value in arrayNumbers)
           {
               Console.Write($"{value} ");
           } 
        }
    }
}
