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

            while (isReadyGetCard == true)
            {
                
                Console.WriteLine("Для того чтобы ещё взять карту из колоды напишите 1, если хватит брать карты напишите 2");
                int.TryParse(Console.ReadLine(), out int input);

                switch (input)
                {
                    case 1:
                        deck.AddCardDeckPlayer();
                        break;
                    case 2:
                        isReadyGetCard = false;
                        break;
                    default:
                        Console.WriteLine("Введено не корректное значение");
                        break;
                }
            }

            deck.ShowCardsDeck();
        }
    }

    class Card
    {
        private int _valueCard;
        private int _numberCard; 
        private string[] _namesCards = {"Камень","Ножниц","Бумага","Колодец","Пики","Крести","Буби","Черви"};
        private Random _random = new Random();

        public int Number { get; private set;}
        public string NameCard { get; private set; }

        public Card()
        {
            SetValueCard();
            NameCard = _namesCards[_numberCard];
            Number = _valueCard;
        }

        private void SetValueCard()
        {
            _valueCard = _random.Next(0, 100);
            _numberCard = _random.Next(_namesCards.Length);
        }
       
        public void ShowInfoCard()
        {
            Console.WriteLine($"Номер вашей карты {Number}, Название вашей карты {NameCard}");
        }
    }

    class Deck
    {
        private List<Card> _cards = new List<Card>();
        
        public void AddCardDeckPlayer()
        {
            _cards.Add(new Card());
            Console.WriteLine($"У вас всего {_cards.Count} карт на руке");
        }

        public void ShowCardsDeck()
        {
            if (_cards.Count > 0)
            {
                foreach( Card card in _cards)
                {
                    card.ShowInfoCard();   
                }
            }
            else
            {
                Console.WriteLine("Вы не взяли не одной карты");
            }
        }   
    }
}
