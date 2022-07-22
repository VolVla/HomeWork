using System;
using System.Collections.Generic;

namespace DictionaryBook
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isBookStorageWork = true;
            BookStorage bookStorage = new BookStorage();

            while (isBookStorageWork == true)
            {
                Console.WriteLine("\nДобро пожаловать в хранилище книг");
                Console.WriteLine("1 - Добавить книгу в хранилище, 2 - убрать книгу из хранилища, 3 - Показать все книги, 4 - Показать книги по указанному параметру, 5 - Выйти из программы");

                switch (Console.ReadLine())
                {
                    case "1":
                        bookStorage.AddBook();
                        break;
                    case "2":
                        bookStorage.RemoveBook();
                        break;
                    case "3":
                        bookStorage.ShowAllBook();
                        break;
                    case "4":
                        bookStorage.SortBookStorage();
                        break;
                    case "5":
                        Console.WriteLine("Вы вышли из программы");
                        _isBookStorageWork = false;
                        break;
                    default:
                        Console.WriteLine("Данные не корректны");
                        break;
                }
            }
        }
    }

    class BookStorage
    {
        private List<Book> _books = new List<Book>();

        public void AddBook()
        {
            string nameBook;
            string nameAutor;
            bool isAge;
            bool isQuantityBook;

            Console.WriteLine("Введите название книги");
            nameBook = Console.ReadLine();
            Console.WriteLine("Введите автора книги");
            nameAutor = Console.ReadLine();
            Console.WriteLine("Введите дату созданию книги");
            isAge = int.TryParse(Console.ReadLine(), out int ageRelease);
            
            if (isAge == false)
            {
                Console.WriteLine("Неккоректный ввод.");
                return;
            }

            Console.WriteLine("Введите количество книг");
            isQuantityBook = int.TryParse(Console.ReadLine(), out int quantityBooks);

            if ((isAge && isQuantityBook) != false)
            {
                _books.Add(new Book(ageRelease, nameBook, nameAutor, quantityBooks));
            }
            else
            {
                Console.WriteLine("Неккоректный ввод.");
                return;
            }
        }

        public void RemoveBook()
        {
            string input;

            if (_books.Count > 0)
            {
                ShowAllBook();
                Console.WriteLine("Введите название книги");
                input = Console.ReadLine();

                for (int i = 0; i < _books.Count; i++)
                {
                    if (_books[i]._nameBook == input)
                    {
                        _books.RemoveAt(i);
                        Console.WriteLine("Книга была убрана из хранилища.");
                    }
                    else
                    {
                        Console.WriteLine("Введено не коректные данные.");
                    }
                }
            }
            else
            {
                Console.WriteLine("В вашем хранилище нет книг, сначало положите их");
            }
        }

        public void ShowAllBook()
        {
            Console.WriteLine("Книги в хранилище.");

            if (_books.Count > 0)
            {
                foreach (Book book in _books)
                {
                    book.ShowInfo();
                }
            }
            else
            {
                Console.WriteLine("В вашем хранилище нет книг, сначало положите их");
            }
        }

        public void SortBookStorage()
        {
            if (_books.Count > 0)
            {
                Console.WriteLine($"Для сортировки книг по название напишите 1. Для сортировки по автору книги напишите 2 . Для сортировки по дате создание книги пишите 3");

                switch (Console.ReadLine())
                {
                    case "1":
                        SortTitleBook();
                        break;
                    case "2":
                        SortNameAutor();
                        break;
                    case "3":
                        SortAgeRelease();
                        break;
                    default:
                        Console.WriteLine("Данные не корректны");
                        break;
                }
            }
            else
            {
                Console.WriteLine("В вашем хранилище нет книг, сначало положите их");
            }
        }

        public void SortTitleBook()
        {
            bool isFound = false;
            string input;
            Console.WriteLine("Введите название книги");
            input = Console.ReadLine();

            foreach (Book book in _books)
            {
                if (book._nameBook == input)
                {
                    book.ShowInfo();
                    isFound = true;
                }
            }

            if (isFound == false)
            {
                Console.Write("\nДанная книга не была найдена");
            }
        }

        public void SortNameAutor()
        {
            bool isFound = false;
            string input;
            Console.WriteLine("Введите автора книги");
            input = Console.ReadLine();

            foreach (Book book in _books)
            {
                if (book._autorBook == input)
                {
                    book.ShowInfo();
                    isFound = true;
                }
            }

            if (isFound == false)
            {
                Console.Write("\nДанная книга не была найдена");
            }
        }

        public void SortAgeRelease()
        {
            bool isFound = false;
            bool isNumber;
            Console.WriteLine("Введите дату создании книги");
            isNumber = int.TryParse(Console.ReadLine(), out int age);

            if (isNumber == true)
            {
                foreach (Book book in _books)
                {
                    if (book._ageRelease == age)
                    {
                        book.ShowInfo();
                        isFound = true;
                    }
                }

                if (isFound == false)
                {
                    Console.Write("\nДанная книга не была найдена");
                }
            }
            else
            {
                Console.WriteLine("Книг с текущей даты создания нету");
            }
        }
    }

    class Book
    {
        public string NameBook { get; private set; }
        public string AutorBook { get; private set; }
        public int AgeRelease { get; private set; }
        public int QuantityBooks { get; private set; }

        public Book(int ageRelease, string nameBook, string autorBook, int quantityBooks)
        {
            AgeRelease = ageRelease;
            NameBook = nameBook;
            AutorBook = autorBook;
            QuantityBooks = quantityBooks;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Название книги - {NameBook}, Имя автора - {AutorBook}, Год релиза книги - {AgeRelease}, Количество книг - {QuantityBooks}");
        }
    }
} 
