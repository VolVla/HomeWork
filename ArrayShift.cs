using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayShift
{
    class Program
    {
        static void Main()
        {
            const int AmountArray = 5;
            int[] arrayNumbers = new int[AmountArray] {1,2,3,4,5};
            int valueShiftLeft;

            valueShiftLeft = Convert.ToInt32(Console.ReadLine());

            for (int i = arrayNumbers.Length; i > valueShiftLeft; --i)
            {
                int aLast = arrayNumbers[arrayNumbers.Length - 1];

                for (int j = arrayNumbers.Length - 1; j > 0; j--) 
                {
                    arrayNumbers[j] = arrayNumbers[j - 1];
                }
                
                arrayNumbers[0] = aLast;
            }

            foreach (int number in arrayNumbers)
            {
                Console.WriteLine($" {number}");
            }
        }
    }
}
