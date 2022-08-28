using System;
using System.Collections.Generic;

namespace StoreItems
{
    internal class Program
    {
        static void Main()
        {
            const string ShowProductCommand = "1";
            const string BuyProductCommand = "2";
            const string ShowItemsCommand = "3";
            const string ExitProgramCommand = "4";
            Seller seller = new Seller(); 
            Player player = new Player();
            string userInput;
            bool isExitShop = true;
            
            while (isExitShop)
            {
                Console.WriteLine("\nПриветствую в своем магазине чтобы посмотреть товар напиши 1,\nДля покупки товар напишите 2,\nДля просмотра предметов в инвентаре напишите 3,\nДля того, чтобы закончить покупки напишите 4");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case ShowProductCommand:
                        seller.ShowProduct();
                        break;
                    case BuyProductCommand:
                        player.BuyProductFromSeller(seller.Products, seller.PriceItem);
                        break;
                    case ShowItemsCommand:
                        player.ShowItems();
                        break;
                    case ExitProgramCommand:
                        isExitShop = false;
                        Console.WriteLine("Вы закончили покупки и вышли из магазина");
                        break;
                    default:
                        Console.WriteLine("Ошибка неизвестная команда");
                        break;
                }
            }
        } 
    }

    class Seller
    {
        public List<Item> Products = new List<Item>()
        {
            new Item("Зелье здоровья",5),new Item("Зелье маны",4),
            new Item("Шлем",10),new Item("Копьё",8),
            new Item("Нагрудник",9),new Item("Поножи",8),
            new Item("Ботинки",14),new Item("Ожерелье",2),
            new Item("Браслет",7),new Item("Перчатки",3),
            new Item("Топор",13),new Item("Меч",20),
            new Item("Лук",16),new Item("Колчан стрел",6)
        };
        public int PriceItem { get;private set; }

        public void ShowProduct()
        {
            foreach(Item item in Products)
            {
                int index = Products.IndexOf(item);
                Console.Write(index);
                item.ShowInfoProduct();
            }
        }
    }

    class Player
    {
        private List<Item> items = new List<Item>();
        private int _balanceMoney = 100;
        
        public void BuyProductFromSeller(List<Item> products,int priceItem)
        { 
            Console.WriteLine($"Ваш баланс {_balanceMoney} монет");

            if (products.Count > 0)
            {
                Console.WriteLine("Введите номер предмета");
                int.TryParse(Console.ReadLine() , out int index);

                if (index < products.Count && index >= 0)
                {
                    priceItem = products[index].AmountSellPrice; 

                    if(_balanceMoney >= priceItem)
                    {
                        _balanceMoney -= priceItem;
                        items.Add(products[index]);
                        products.Remove(products[index]);
                        Console.WriteLine("Поздравляю вы купили товар.");
                    }
                    else
                    {
                        Console.WriteLine("Извините, но у вас не достаточно денег.");
                    }
                }
                else
                {
                    Console.WriteLine("Введен не корректный номер предмета");
                }
            }
            else
            {
                Console.WriteLine("Извините,но весь товар уже распродан.");
            }
        }

        public void ShowItems()
        {
            foreach (Item item in items)
            {
                string name =  item.NameProduct;
                Console.WriteLine($"У вас в инвентаре {name}");
            }
        }
    }

    class Item
    {
        public int AmountSellPrice { get;private set; }
        public string NameProduct { get; private set; }

        public Item(string _nameProduct, int _sellPrice)
        {
            AmountSellPrice = _sellPrice;
            NameProduct = _nameProduct;
        }

        public void ShowInfoProduct()
        {
            Console.WriteLine($" номер предмета, название предмета '{NameProduct}', стоимость предмета {AmountSellPrice}");
        }
    }
}
