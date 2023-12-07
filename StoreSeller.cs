using System;
using System.Collections.Generic;

namespace StoreItems
{
    internal class Program
    {
        static void Main()
        {
            Shop shop = new Shop();
            shop.WorkShop();
        }
    }

    class Shop
    {
        private Seller _seller = new Seller();
        private Buyer _buyer = new Buyer();

        public void WorkShop()
        {
            const string ShowProductCommand = "1";
            const string BuyProductCommand = "2";
            const string ShowItemsCommand = "3";
            const string ExitProgramCommand = "4";

            string userInput;
            bool isExitShop = true;

            while (isExitShop)
            {
                Console.WriteLine($"\nПриветствую в своем магазине чтобы посмотреть товар напиши {ShowProductCommand},\nДля покупки товар напишите {BuyProductCommand},\nДля просмотра предметов в инвентаре напишите {ShowItemsCommand},\nБалланс продавца - {_seller.GetBalance()}\nДля того, чтобы закончить покупки напишите {ExitProgramCommand}");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case ShowProductCommand:
                        _seller.ShowInfo();
                        break;
                    case BuyProductCommand:
                        SellItem();
                        break;
                    case ShowItemsCommand:
                        _buyer.ShowInfo();
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

        public void SellItem()
        {
            Console.WriteLine($"Баланс покупателя {_buyer.GetBalance()} монет");

            if (_seller.GetListItems().Count > 0)
            {
                Console.WriteLine("Введите номер предмета");
                int.TryParse(Console.ReadLine(), out int index);

                if (index < _seller.GetListItems().Count && index >= 0)
                {
                    if (_buyer.GetBalance() >= _seller.GetListItems()[index].Price)
                    {
                        _buyer.RemoveMoney(_seller.GetListItems()[index].Price);
                        _seller.AddMoney(_seller.GetListItems()[index].Price);
                        _buyer.TakeItem(_seller.GetListItems()[index]);
                        _seller.RemoveItem(_seller.GetListItems()[index]);
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
    }

    class Seller : Human
    {
        public Seller()
        {
            Balance = 10000;
            Items.Add(new Item("Зелье здоровья", 5));
            Items.Add(new Item("Зелье маны", 4));
            Items.Add(new Item("Шлем", 10));
            Items.Add(new Item("Копьё", 8));
            Items.Add(new Item("Нагрудник", 9));
            Items.Add(new Item("Поножи", 8));
            Items.Add(new Item("Ботинки", 14));
            Items.Add(new Item("Ожерелье", 2));
            Items.Add(new Item("Браслет", 7));
            Items.Add(new Item("Перчатки", 3));
            Items.Add(new Item("Топор", 13));
            Items.Add(new Item("Меч", 20));
            Items.Add(new Item("Лук", 16));
            Items.Add(new Item("Колчан стрел", 6));
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }

        public override void ShowInfo()
        {
            foreach (Item item in Items)
            {
                int index = Items.IndexOf(item);
                Console.WriteLine($"{index} Название предмета {item.Name}, стоимость предмета {item.Price} монет");
            }
        }
    }

    class Buyer : Human
    {
        public Buyer()
        {
            Balance = 100;
        }

        public void TakeItem(Item product)
        {
            Items.Add(product);
        }

        public override void ShowInfo()
        {
            foreach (Item item in Items)
            {
                Console.WriteLine(item.Name);
            }
        }
    }

    class Item
    {
        public Item(string name, int sellPrice)
        {
            Price = sellPrice;
            Name = name;
        }

        public int Price { get; private set; }
        public string Name { get; private set; }
    }

    abstract class Human
    {
        protected List<Item> Items = new List<Item>();

        protected int Balance { get; set; }

        public abstract void ShowInfo();

        public int GetBalance()
        {
            return Balance;
        }

        public List<Item> GetListItems()
        {
            return Items;
        }

        public void RemoveMoney(int money)
        {
            Balance -= money;
        }

        public void AddMoney(int money)
        {
            Balance += money;
        }
    }
}
