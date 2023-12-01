using System;
using System.Collections.Generic;

namespace DeckCards
{
    internal class Program
    {
        static void Main()
        {
            const string TakeCardCommand = "1";
            const string ShowCardHandCommand = "2";
            const string ExitProgramCommand = "3";

            Deck deck = new Deck();
            Player player = new Player();
            bool isReadyGetCard = true;
            string userInput;

            while (isReadyGetCard)
            {
                Console.WriteLine($"Для того чтобы ещё взять карту из колоды напишите {TakeCardCommand},\nДля того чтобы показать карты на руке напишите {ShowCardHandCommand}.\nДля выход из программы напишите {ExitProgramCommand}");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case TakeCardCommand:
                        player.TakeCard(deck.GiveCard());
                        break;
                    case ShowCardHandCommand:
                        player.ShowCards();
                        break;
                    case ExitProgramCommand:
                        isReadyGetCard = false;
                        break;
                    default:
                        Console.WriteLine("Введено не корректное значение");
                        break;
                }
            }
        }
    }

    class Deck
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

        public Card GiveCard()
        {
            int minimalNumberCard = 0;
            int firstCard = 0;
            Card card;

            if (_allCards.Count > minimalNumberCard)
            {
                card = _allCards[firstCard];
                _allCards.Remove(card);
                Console.WriteLine("Игрок взял карту и колода перемешалась");
                ShuffleCards();
            }
            else
            {
                card = null;
            }

            return card;
        }

        private void ShuffleCards()
        {
            Random random = new Random();
            int listLength = _allCards.Count;
            int minimumValue = 1;

            while (listLength > minimumValue)
            {
                int randomNumber = random.Next(listLength);
                listLength--;
                int temporaryValue = _allCards.IndexOf(_allCards[listLength]);
                _allCards[listLength] = _allCards[randomNumber];
                _allCards[randomNumber] = _allCards[temporaryValue];
            }
        }
    }

    class Player
    {
        private List<Card> _cards = new List<Card>();

        public void TakeCard(Card card)
        {
            _cards.Add(card);
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
        public Card(int number, string name)
        {
            Name = name;
            Value = number;
        }

        public string Name { get; private set; }
        public int Value { get; private set; }
    }
}
