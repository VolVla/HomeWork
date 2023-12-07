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
            const int CommandShowAllBooks = 3;
            const int CommandOutBookParameter = 4;
            const int CommandProgramExit = 5;

            bool isExit = true;
            BookStorage bookStorage = new BookStorage();

            while (isExit == true)
            {
                Console.WriteLine("\nДобро пожаловать в хранилище книг");
                Console.WriteLine($"{CommandAddBook} - Добавить книгу в хранилище, {CommandRemoveBook} - убрать книгу из хранилища, {CommandShowAllBooks} - Показать все книги, {CommandOutBookParameter} - Показать книги по указанному параметру, {CommandProgramExit} - Выйти из программы");
                int.TryParse(Console.ReadLine(), out int number);

                switch (number)
                {
                    case CommandAddBook:
                        bookStorage.AddBook();
                        break;
                    case CommandRemoveBook:
                        bookStorage.RemoveBook();
                        break;
                    case CommandShowAllBooks:
                        bookStorage.ShowAllBooks();
                        break;
                    case CommandOutBookParameter:
                        bookStorage.ShowBookByParameter();
                        break;
                    case CommandProgramExit:
                        Console.WriteLine("Вы вышли из программы");
                        isExit = false;
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
            string bookName;
            string autorName;
            bool isSetBookData;

            Console.WriteLine("Введите название книги");
            bookName = Console.ReadLine();
            Console.WriteLine("Введите автора книги");
            autorName = Console.ReadLine();
            Console.WriteLine("Введите дату созданию книги");
            isSetBookData = int.TryParse(Console.ReadLine(), out int ageRelease);

            if (isSetBookData == true)
            {
                _books.Add(new Book(ageRelease, bookName, autorName));
            }
            else
            {
                Console.WriteLine("Неккоректный ввод.");
            }
        }

        public void RemoveBook()
        {
            if (_books.Count > 0)
            {
                ShowAllBooks();
                Console.WriteLine("Введите номер книги");
                int.TryParse(Console.ReadLine(), out int numberBook);

                if (_books.Count >= numberBook & numberBook > 0)
                {
                    _books.RemoveAt(numberBook - 1);
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

        public void ShowAllBooks()
        {
            Console.WriteLine("Книги в хранилище.");

            if (_books.Count > 0)
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

        public void ShowBookByParameter()
        {
            const string CommandSortBookByName = "1";
            const string CommandSortBookByAuthor = "2";
            const string CommandSortBookByDate = "3";

            if (_books.Count > 0)
            {
                Console.WriteLine($"Для сортировки книг по название напишите {CommandSortBookByName}. Для сортировки по автору книги напишите {CommandSortBookByAuthor} . Для сортировки по дате создание книги пишите {CommandSortBookByDate}");

                switch (Console.ReadLine())
                {
                    case CommandSortBookByName:
                        ShowBooksByTitle();
                        break;
                    case CommandSortBookByAuthor:
                        ShowBookByAutorName();
                        break;
                    case CommandSortBookByDate:
                        ShowBookByReleaseDate();
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

        private void ShowBooksByTitle()
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

        private void ShowBookByAutorName()
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

        private void ShowBookByReleaseDate()
        {
            bool isFound = false;
            Console.WriteLine("Введите дату создании книги");

            if (int.TryParse(Console.ReadLine(), out int age))
            {
                foreach (Book book in _books)
                {
                    if (book.ReleaseAge == age)
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
            ReleaseAge = ageRelease;
            Name = nameBook;
            Autor = autorBook;
        }

        public string Name { get; private set; }
        public string Autor { get; private set; }
        public int ReleaseAge { get; private set; }

        public void ShowInfo()
        {
            Console.WriteLine($" Название книги - {Name}, Имя автора - {Autor}, Год релиза книги - {ReleaseAge}");
        }
    }
}
