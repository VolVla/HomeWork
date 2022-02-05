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
            int volumeImage = 52;
            int volumeRow = 3;
            int filledRow;
            int overMeasureImage;
            filledRow = volumeImage / volumeRow;
            overMeasureImage = 52 % 3;
            Console.WriteLine("У вас " + filledRow + " полностью заполненных рядов ,и " + overMeasureImage + " картинок сверх меры");

        }
    }
}
