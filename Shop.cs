using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int goldPlayer;
            int crystalPlayer = 0;
            int priceCristal = 2;
            int volumeBuyCrystal;

            
            Console.Write("Введите начально кол-во золота:");
            goldPlayer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Добрый день. Добро пожаловать в мой магазин. Один Кристал стоит " + priceCristal + " золота.");
            Console.WriteLine("Cколько кристаллов вы хотите купить?");
            volumeBuyCrystal = Convert.ToInt32(Console.ReadLine());

            goldPlayer = goldPlayer - (volumeBuyCrystal * priceCristal);
            crystalPlayer += volumeBuyCrystal;
            Console.WriteLine("Вы купили: " + volumeBuyCrystal + " кристалов по цене:" + priceCristal + " золота.");
            Console.WriteLine("У вас в рюкзаке: " + goldPlayer + " золота и " + crystalPlayer + " кристалов." );

        }
    }
}
