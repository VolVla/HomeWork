using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfImages = 52;
            int capacityRow = 3;
            int filledOfRow;
            int imageBeyondMeasure;
            
            filledOfRow = numberOfImages / capacityRow;
            imageBeyondMeasure = numberOfImages % capacityRow;
            Console.WriteLine("У вас " + filledOfRow + " полностью заполненных рядов ,и " + imageBeyondMeasure + " картинка сверх меры");

        }
    }
}
