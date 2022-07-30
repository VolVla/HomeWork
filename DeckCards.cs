using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckCards
{
    internal class Program
    {
        static void Main(string[] args)
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
    }

    class DeckCards
    {
        public List<Card> AllCards = new List<Card>() 
        {
            new Card(0,"Камень"),new Card(1,"Ножниц"), new Card(2,"Бумага"),
            new Card(3,"Колодец"), new Card(4,"Пики"), new Card(5,"Крести"),
            new Card(6,"Буби"), new Card(7,"Черви"), new Card(8,"Дом"),
            new Card(9,"Улица"), new Card(10,"Аптека"), new Card(11,"Машина"),
            new Card(12,"Самолет"),new Card(13,"Носок"),new Card(14,"Шляпа"),
            new Card(15,"Собака"),new Card(16,"Стол"),new Card(17,"Кружка"),
            new Card(18,"Шторы"),new Card(19,"Чашка"),new Card(20,"Велосипед")
        };

        public int ShowLengt()
        {
            return AllCards.Count;
        }

        public void Delete(int indexCard)
        {
            AllCards.Remove(AllCards[indexCard]);
        }
    }
    
    class Card
    {
        public string Name { get;private set; }
        public int Value { get; private set; }

        public Card(int number,string name)
        {
            Name = name;
            Value = number;
        }
    }

    class Player
    {
        private DeckCards _deckCards = new DeckCards();
        private List<Card> _cards = new List<Card>();
        private Random _random = new Random();
        private int _minSizeDeck = 0;

        public void AddCard()
        {
            if(_deckCards.ShowLengt() != _minSizeDeck)
            {
                Console.WriteLine("Введите кол-во карт которых хотите вы взять.");
                bool isNumber = int.TryParse(Console.ReadLine(), out int input);

                if (isNumber == true && input <= _deckCards.ShowLengt())
                {
                    for(int i = 0; i < input; i++)
                    {
                        int randomNumber = _random.Next(_minSizeDeck,_deckCards.ShowLengt());
                        _cards.Add(_deckCards.AllCards[randomNumber]);
                        _deckCards.Delete(randomNumber);
                    }
                }
                else if(input >= _deckCards.ShowLengt())
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
            if (_cards.Count > _minSizeDeck)
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
}
