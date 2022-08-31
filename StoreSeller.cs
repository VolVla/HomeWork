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
            Buyer buyer = new Buyer();
            string userInput;
            bool isExitShop = true;
            int _balanceMoney = 100;

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
                        buyer.TakeItem(seller.TransferItem(ref _balanceMoney));
                        break;
                    case ShowItemsCommand:
                        buyer.ShowInBag();
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

    class Seller : Player
    {
        private List<Item> _products = new List<Item>();
        private int _priceItem;

        public Item Product { get;private set  ;}

        public Seller()
        {
            _products.Add(new Item("Зелье здоровья", 5));
            _products.Add(new Item("Зелье маны", 4));
            _products.Add(new Item("Шлем", 10));
            _products.Add(new Item("Копьё", 8));
            _products.Add(new Item("Нагрудник", 9));
            _products.Add(new Item("Поножи", 8));
            _products.Add(new Item("Ботинки", 14));
            _products.Add(new Item("Ожерелье", 2));
            _products.Add(new Item("Браслет", 7));
            _products.Add(new Item("Перчатки", 3));
            _products.Add(new Item("Топор", 13));
            _products.Add(new Item("Меч", 20));
            _products.Add(new Item("Лук", 16));
            _products.Add(new Item("Колчан стрел", 6));
        }

        private void BuyProductFromSeller(ref int _balanceMoney)
        { 
            Console.WriteLine($"Ваш баланс {_balanceMoney} монет");

            if (_products.Count > 0)
            {
                Console.WriteLine("Введите номер предмета");
                int.TryParse(Console.ReadLine() , out int index);

                if (index < _products.Count && index >= 0)
                {
                    _priceItem = _products[index].AmountSellPrice; 

                    if(_balanceMoney >= _priceItem)
                    {
                        _balanceMoney -= _priceItem;
                        Product = _products[index];
                        _products.Remove(_products[index]);
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

        public void ShowProduct()
        {
            foreach(Item item in _products)
            {
                int index = _products.IndexOf(item);
                Console.Write(index);
                item.ShowInfoProduct();
            }
        }

        public Item TransferItem(ref int money)
        {
            BuyProductFromSeller(ref money);
            return Product;
        }
    }

    class Buyer : Player
    {
        public void TakeItem(Item product)
        {
            _items.Add(product);
        }

        public void ShowInBag()
        {
            foreach(Item item in _items)
            {
                Console.WriteLine(item.Name);
            }
        }
    }

    class Player
    {
        private protected List<Item> _items = new List<Item>();
        
        public void ShowItems()
        {
            foreach (Item item in _items)
            {
                item.ShowInfoProduct();
            }
        }
    }

    class Item
    {
        public int AmountSellPrice { get;private set; }
        public string Name { get; private set; }

        public Item(string name, int sellPrice)
        {
            AmountSellPrice = sellPrice;
            Name = name;
        }

        public void ShowInfoProduct()
        {
            Console.WriteLine($" Название предмета '{Name}', стоимость предмета {AmountSellPrice} монет");
        }
    }
}
