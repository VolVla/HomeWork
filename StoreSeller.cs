using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreItems
{
    internal class Player
    {
        static void Main(string[] args)
        {
            bool isExitShop = false;
            Seller seller = new Seller();
            int balancePlayer = 100;

            List<Item> ItemPlayer = new List<Item>();

            while (isExitShop == true)
            {
                Console.WriteLine("Приветствую в своем магазине чтобы посмотреть товар напиши 1, чтобы купить товар напишите 2");
                int.TryParse(Console.ReadLine(), out int input);
                switch (input)
                {
                    case 1:
                        seller.ShowProducts();
                        break;
                    case 2:
                        break;
                    case 3:
                        isExitShop = false;
                        Console.WriteLine("Вы закончили покупки и вышли из магазина");
                        break;
                }
            }
        }

        public void BuyProductFromSeller()
        {

        }
    }

    class Seller
    {
        private List<Item> _items = new List<Item>()
        {
            new Item("Зелье здоровья",5),new Item("Зелье маны",4),
            new Item("Шлем",10),new Item("Копьё",8)
            ,new Item("Нагрудник",9),new Item("Поножи",8)
            ,new Item("Ботинки",14),new Item("Ожерелье",2)
            ,new Item("Браслет",7),new Item("Перчатки",3)
            ,new Item("Топор",13),new Item("Меч",20)
            ,new Item("Лук",16),new Item("Колчан стрел",6)
        };

        public void ShowProducts()
        {
            foreach(Item product in _items)
            {
                product.ShowInfoProduct();
            }
        }
    }

    class Item
    {
        private int _sellPrice;
        private int _numberItem;
        private string _nameItem;

        public int AmountSellPrice { get;private set; }
        public string NameProduct { get; private set; }



        public Item(string NameProduct, int AmountSellPrice)
        {
            AmountSellPrice = _sellPrice;
            NameProduct = _nameItem;
        }
       
        public void ShowInfoProduct()
        {
            Console.WriteLine($"Торговец показывает предмет {NameProduct},стоимость {AmountSellPrice}");
        }
    }
}
