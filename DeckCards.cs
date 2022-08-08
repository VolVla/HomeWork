using System;
using System.Collections.Generic;


namespace DeckCards
{
    internal class DeckCards
    {
        private List<Card> _allCards = new List<Card>()
            {
                new Card(0,"Камень"),new Card(1,"Ножниц"), new Card(2,"Бумага"),
                new Card(3,"Колодец"), new Card(4,"Пики"), new Card(5,"Крести"),
                new Card(6,"Буби"), new Card(7,"Черви"), new Card(8,"Дом"),
                new Card(9,"Улица"), new Card(10,"Аптека"), new Card(11,"Машина"),
                new Card(12,"Самолет"),new Card(13,"Носок"),new Card(14,"Шляпа"),
                new Card(15,"Собака"),new Card(16,"Стол"),new Card(17,"Кружка"),
                new Card(18,"Шторы"),new Card(19,"Чашка"),new Card(20,"Велосипед")
            };

        static void Main()
        {
            Player player = new Player();
            bool isReadyGetCard = true;

            while (isReadyGetCard)
            {
                Console.WriteLine("Для того чтобы ещё взять карту из колоды напишите 1,\nДля того чтобы показать карты на руке напишите 2.\nВыход напишите 3");

                switch (Console.ReadLine())
                {
                    case "1":
                        player.AddCard();
                        break;
                    case "2":
                        player.ShowCards();
                        break;
                    case "3":
                        isReadyGetCard = false;
                        break;
                    default:
                        Console.WriteLine("Введено не корректное значение");
                        break;
                }
            }
        }

        public List<Card> TransferCards()
        {
            return _allCards;
        }

        public int ShowLenght()
        {
            return _allCards.Count;
        }

        public void Delete(int indexCard)
        {
            _allCards.Remove(_allCards[indexCard]);
        }
    }
 
    class Player
    {
        private DeckCards _deckCards = new DeckCards();
        private List<Card> _cards = new List<Card>();
        private Random _random = new Random();

        public void AddCard()
        {
            if (_deckCards.ShowLenght() != 0)
            {
                Console.WriteLine("Введите кол-во карт которых хотите вы взять.");
                bool isNumber = int.TryParse(Console.ReadLine(), out int input);

                if (isNumber == true && input <= _deckCards.ShowLenght())
                {
                    for (int i = 0; i < input; i++)
                    {
                        int randomNumber = _random.Next(0, _deckCards.ShowLenght());
                        _cards.Add(_deckCards.TransferCards()[randomNumber]);
                        _deckCards.Delete(randomNumber);
                    }
                }
                else if (input >= _deckCards.ShowLenght()) 
                {
                    Console.WriteLine("Вы пытаетесь взять больше карт чем есть в колоде");
                }
            }
            else
            {
                Console.WriteLine("Извините карты закончились,Вы не можете взять больше");
            }
        }

        public void ShowCards()
        {
            if (_cards.Count > 0)
            {
                foreach (Card card in _cards)
                {
                    Console.WriteLine($"Название карты {card.Name}, величина карты {card.Value}");
                }
            }
            else
            {
                Console.WriteLine($"Вы не взяли не одной карты\n");
            }
        }
    }

    class Card
    {
        public string Name { get; private set; }
        public int Value { get; private set; }

        public Card(int number, string name)
        {
            Name = name;
            Value = number;
        }
    }
}
