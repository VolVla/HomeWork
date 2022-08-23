using System;
using System.Collections.Generic;

namespace StoreItems
{
    internal class Program
    {
        static void Main()
        {
            bool isExitShop = true;
            Seller seller = new Seller();

            while (isExitShop)
            {
                Console.WriteLine("\nПриветствую в своем магазине чтобы посмотреть товар напиши 1,\nДля покупки товар напишите 2,\nДля просмотра предметов в инвентаре напишите 3,\nДля того, чтобы закончить покупки напишите 4");
                int.TryParse(Console.ReadLine(), out int userInput);

                switch (userInput)
                {
                    case 1:
                        seller.ShowProduct();
                        break;
                    case 2:
                        seller.BuyProductFromSeller();
                        break;
                    case 3:
                        seller.ShowItemPlayer();
                        break;
                    case 4:
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
        private List<Item> _products = new List<Item>()
        {
            new Item("Зелье здоровья",5),new Item("Зелье маны",4),
            new Item("Шлем",10),new Item("Копьё",8),
            new Item("Нагрудник",9),new Item("Поножи",8),
            new Item("Ботинки",14),new Item("Ожерелье",2),
            new Item("Браслет",7),new Item("Перчатки",3),
            new Item("Топор",13),new Item("Меч",20),
            new Item("Лук",16),new Item("Колчан стрел",6)
        };
        private Player _player = new Player();
        private int _balancePlayer;
        private int _priceItem;

        public void BuyProductFromSeller()
        { 
            _balancePlayer = _player.ShowBalance();
            Console.WriteLine($"Ваш баланс {_balancePlayer} монет");

            if (_products.Count > 0)
            {
                Console.WriteLine("Введите номер предмета");
                bool number = int.TryParse(Console.ReadLine() , out int index);

                if (number)
                {
                    _priceItem = _products[index].AmountSellPrice;

                    if(_balancePlayer >= _priceItem)
                    {
                        _player.Money(_priceItem);
                        _player.GetItem(index,_products);
                        RemoveItem(index);
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

        public void ShowItemPlayer()
        {
            _player.ShowItems();
        }

        public void RemoveItem(int indexItem)
        {
            _products.Remove(_products[indexItem]);
        }
    }

    class Player
    {
        private List<Item> _items = new List<Item>();
        private int balancePlayer = 100;
       
        public void Money(int priceItem)
        {
            balancePlayer -= priceItem;
        }

        public int ShowBalance()
        {
            return balancePlayer;
        }

        public void GetItem(int index,List<Item> _products)
        {
            _items.Add(_products[index]);
        }

        public void ShowItems()
        {
            foreach (Item item in _items)
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
