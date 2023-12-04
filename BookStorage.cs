using System;
using System.Collections.Generic;

namespace DictionaryBook
{
    class Program
    {
        static void Main()
        {
            const int CommandAddBook = 1;
            const int CommandRemoveBook = 2;
            const int CommandShowAllBook = 3;
            const int CommandSortBookStorage = 4;
            const int CommandExitProgram = 5;

            bool _isExit = true;
            BookStorage bookStorage = new BookStorage();

            while (_isExit == true)
            {
                Console.WriteLine("\nДобро пожаловать в хранилище книг");
                Console.WriteLine("1 - Добавить книгу в хранилище, 2 - убрать книгу из хранилища, 3 - Показать все книги, 4 - Показать книги по указанному параметру, 5 - Выйти из программы");
                int.TryParse(Console.ReadLine(), out int number);

                switch (number)
                {
                    case CommandAddBook:
                        bookStorage.AddBook();
                        break;
                    case CommandRemoveBook:
                        bookStorage.RemoveBook();
                        break;
                    case CommandShowAllBook:
                        bookStorage.ShowAllBook();
                        break;
                    case CommandSortBookStorage:
                        bookStorage.SortBooks();
                        break;
                    case CommandExitProgram:
                        Console.WriteLine("Вы вышли из программы");
                        _isExit = false;
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
        private int _minimumAmountBook = 0;

        public void AddBook()
        {
            string nameBook;
            string nameAutor;
            bool isSetBookData;

            Console.WriteLine("Введите название книги");
            nameBook = Console.ReadLine();
            Console.WriteLine("Введите автора книги");
            nameAutor = Console.ReadLine();
            Console.WriteLine("Введите дату созданию книги");
            isSetBookData = int.TryParse(Console.ReadLine(), out int ageRelease);

            if (isSetBookData == false)
            {
                Console.WriteLine("Неккоректный ввод.");
                return;
            }

            if ((isSetBookData) != false)
            {
                _books.Add(new Book(ageRelease, nameBook, nameAutor));
            }
            else
            {
                Console.WriteLine("Неккоректный ввод.");
            }
        }

        public void RemoveBook()
        {
            if (_books.Count > _minimumAmountBook)
            {
                ShowAllBook();
                Console.WriteLine("Введите номер книги");
                int.TryParse(Console.ReadLine(), out int numberBook);

                if (_books.Count >= numberBook & numberBook > _minimumAmountBook)
                {
                    _books.Remove(_books[numberBook - 1]);
                    Console.WriteLine("Книга была убрана из хранилища.");
                }
                else
                {
                    Console.WriteLine("Введено не коректные данные.");
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

            if (_books.Count > _minimumAmountBook)
            {
                for (int i = 0; i < _books.Count; i++)
                {
                    Console.Write($"Номер книги - {i + 1}");
                    _books[i].ShowInfo();
                }
            }
            else
            {
                Console.WriteLine("В вашем хранилище нет книг, сначало положите их");
            }
        }

        public void SortBooks()
        {
            const string CommandBookSortByName = "1";
            const string CommandBookSortByAuthor = "2";
            const string CommandBookSortByDate = "3";

            if (_books.Count > 0)
            {
                Console.WriteLine($"Для сортировки книг по название напишите {CommandBookSortByName}. Для сортировки по автору книги напишите {CommandBookSortByAuthor} . Для сортировки по дате создание книги пишите {CommandBookSortByDate}");

                switch (Console.ReadLine())
                {
                    case CommandBookSortByName:
                        SortTitleBook();
                        break;
                    case CommandBookSortByAuthor:
                        SortNameAutor();
                        break;
                    case CommandBookSortByDate:
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

        private void SortTitleBook()
        {
            bool isFound = false;
            string input;
            Console.WriteLine("Введите название книги");
            input = Console.ReadLine();

            foreach (Book book in _books)
            {
                if (book.Name.ToLower() == input.ToLower())
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

        private void SortNameAutor()
        {
            bool isFound = false;
            string input;
            Console.WriteLine("Введите автора книги");
            input = Console.ReadLine();

            foreach (Book book in _books)
            {
                if (book.Autor.ToLower() == input.ToLower())
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

        private void SortAgeRelease()
        {
            bool isFound = false;
            Console.WriteLine("Введите дату создании книги");

            if (int.TryParse(Console.ReadLine(), out int age))
            {
                foreach (Book book in _books)
                {
                    if (book.AgeRelease == age)
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
        public Book(int ageRelease, string nameBook, string autorBook)
        {
            AgeRelease = ageRelease;
            Name = nameBook;
            Autor = autorBook;
        }

        public string Name { get; private set; }
        public string Autor { get; private set; }
        public int AgeRelease { get; private set; }

        public void ShowInfo()
        {
            Console.WriteLine($" Название книги - {Name}, Имя автора - {Autor}, Год релиза книги - {AgeRelease}");
        }
    }
}
