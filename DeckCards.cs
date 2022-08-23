using System;
using System.Collections.Generic;

namespace DeckCards
{
    internal class Program
    {
        static void Main()
        {
            DeckCards deckCard = new DeckCards();
            Player player = new Player();
            bool isReadyGetCard = true;
            string userInput;

            while (isReadyGetCard)
            {
                Console.WriteLine("Для того чтобы ещё взять карту из колоды напишите 1,\nДля того чтобы показать карты на руке напишите 2.\nВыход напишите 3");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        deckCard.GiveCard(player.TakeCard());
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
    }

    class DeckCards
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
        private Random _random = new Random();

        public void GiveCard(List<Card>_deck)
        {
            if (ShowLenght() != 0)
            {
                int randomNumber = _random.Next(0, ShowLenght());
                _deck.Add(ShowCards(randomNumber));
                RemoveCard(randomNumber);
            }
            else
            {
                Console.WriteLine("Извините карты закончились,Вы не можете взять больше");
            }
        }

        public Card ShowCards(int indexCard)
        {
            return _allCards[indexCard];
        }

        public int ShowLenght()
        {
            return _allCards.Count;
        }

        public void RemoveCard(int indexCard)
        {
            _allCards.Remove(_allCards[indexCard]);
        }
    }

    class Player
    {
        private List<Card> _deck = new List<Card>();
        
        public List<Card> TakeCard()
        {
            return _deck;
        }

        public void ShowCards()
        {
            if (_deck.Count > 0)
            {
                foreach (Card card in _deck)
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
