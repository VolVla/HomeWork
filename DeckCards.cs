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
                        player.TakeCard(deck._allCards);
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
        public List<Card> _allCards = new List<Card>()
        {
            new Card(0,"Камень"),new Card(1,"Ножниц"), new Card(2,"Бумага"),
            new Card(3,"Колодец"), new Card(4,"Пики"), new Card(5,"Крести"),
            new Card(6,"Буби"), new Card(7,"Черви"), new Card(8,"Дом"),
            new Card(9,"Улица"), new Card(10,"Аптека"), new Card(11,"Машина"),
            new Card(12,"Самолет"),new Card(13,"Носок"),new Card(14,"Шляпа"),
            new Card(15,"Собака"),new Card(16,"Стол"),new Card(17,"Кружка"),
            new Card(18,"Шторы"),new Card(19,"Чашка"),new Card(20,"Велосипед")
        } ;
    }

    class Player
    {
        private List<Card> _deckHand = new List<Card>();
        private Random _random = new Random();

        public void TakeCard(List<Card> _allCards)
        {
            if (_allCards.Count != 0)
            {
                int randomNumber = _random.Next(0, _allCards.Count);
                _deckHand.Add(_allCards[randomNumber]);
                _allCards.Remove(_allCards[randomNumber]);
            }
            else
            {
                Console.WriteLine("Извините карты закончились,Вы не можете взять больше");
            }
        }

        public void ShowCards()
        {
            if (_deckHand.Count > 0)
            {
                foreach (Card card in _deckHand)
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
