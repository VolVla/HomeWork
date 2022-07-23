using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckCards
{
    internal class Player
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            bool isReadyGetCard = true;

            while (isReadyGetCard)
            {
                Console.WriteLine("Для того чтобы ещё взять карту из колоды напишите 1, если хватит брать карты напишите 2");
                int.TryParse(Console.ReadLine(), out int input);

                switch (input)
                {
                    case 1:
                        deck.AddCard();
                        break;
                    case 2:
                        isReadyGetCard = false;
                        break;
                    default:
                        Console.WriteLine("Введено не корректное значение");
                        break;
                }
            }

            deck.ShowCards();
        }
    }

    class Card
    {
        private int _value;
        private int _number; 
        private string[] _cardsNames = {"Камень","Ножниц","Бумага","Колодец","Пики","Крести","Буби","Черви"};
        private Random _random = new Random();

        public int Number { get; private set;}
        public string CardName { get; private set; }

        public Card()
        {
            SetValue();
            CardName = _cardsNames[_number];
            Number = _value;
        }

        private void SetValue()
        {
            _value = _random.Next(0, 100);
            _number = _random.Next(_cardsNames.Length);
        }
       
        public void ShowInfo()
        {
            Console.WriteLine($"Номер вашей карты {Number}, Название вашей карты {CardName}");
        }
    }

    class Deck
    {
        private List<Card> _cards = new List<Card>();
        
        public void AddCard()
        {
            _cards.Add(new Card());
            Console.WriteLine($"У вас всего {_cards.Count} карт на руке");
        }

        public void ShowCards()
        {
            if (_cards.Count > 0)
            {
                foreach( Card card in _cards)
                {
                    card.ShowInfo();   
                }
            }
            else
            {
                Console.WriteLine("Вы не взяли не одной карты");
            }
        }   
    }
}
