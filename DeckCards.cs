using System;
using System.Collections.Generic;


namespace DeckCards
{
    internal class Program
    { 
        static void Main()
        {
            DeckCards _deckCards = new DeckCards();
            bool isReadyGetCard = true;

            while (isReadyGetCard)
            {
                Console.WriteLine("Для того чтобы ещё взять карту из колоды напишите 1,\nДля того чтобы показать карты на руке напишите 2.\nВыход напишите 3");

                switch (Console.ReadLine())
                {
                    case "1":
                        _deckCards.AddCard();
                        break;
                    case "2":
                        _deckCards.ShowCards();
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
    }

    class Player
    {
        private List<Card> _deck = new List<Card>();

        public List<Card> GetDeckCards()
        {
            return _deck;
        }

        public void SetDeck(List<Card> temporaryDeck)
        {
            _deck = temporaryDeck;
        }
    }

    class DeckCards
    {
        private List<Card> _temporaryDeck = new List<Card>();
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
        private Random _random = new Random();
        Player player = new Player();

        public void AddCard()
        {
            if (ShowLenght() != 0)
            {
                int randomNumber = _random.Next(0,ShowLenght());
                _temporaryDeck = player.GetDeckCards();
                _temporaryDeck.Add(_allCards[randomNumber]);
                player.SetDeck(_temporaryDeck);
                Delete(randomNumber);
            }
            else
            {
                Console.WriteLine("Извините карты закончились,Вы не можете взять больше");
            }
        }

        public int ShowLenght()
        {
            return _allCards.Count;
        }

        public void Delete(int indexCard)
        {
            _allCards.Remove(_allCards[indexCard]);
        }

        public void ShowCards()
        {
            if ( player.GetDeckCards().Count > 0)
            {
                foreach (Card card in player.GetDeckCards())
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
