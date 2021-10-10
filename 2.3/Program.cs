using System;

namespace _2._3
{
    class Book
    {
        private string _title1;
        private string _author1;
        private string _content1;
        public string title1
        {
            get
            {
                return _title1;
            }
            set
            {
                this._title1 = value;
            }
        }
        public string author1
        {
            get
            {
                return _author1;
            }
            set
            {
                this._author1 = value;
            }
        }
        public string content1
        {
            get
            {
                return _content1;
            }
            set
            {
                this._content1 = value;
            }
        }
        public void Show () {
            
        }
    }
    class Title
    {
        private string _title;
        public string title
        {
            get
            {
                return _title ;
            }
            set
            {
                this._title = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Название: {title}");
            Console.ResetColor();
            Book titleBookOne = new Book();
            titleBookOne.title1 = title;
            titleBookOne.Show();
        }
    }
    class Author
    {
        private string _author;
        public string author
        {
            get
            {
                return _author;
            }
            set
            {
                this._author = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Автор: {author}");
            Console.ResetColor();
            Book authorBookOne = new Book();
            authorBookOne.author1 = author;
            authorBookOne.Show();
        }
    }
    class Content
    {
        private string _content;
        public string content
        {
            get
            {
                return _content;
            }
            set
            {
                this._content = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Содержание: {content}");
            Console.ResetColor();
            Book contentBookOne = new Book();
            contentBookOne.content1 = content;
            contentBookOne.Show();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Title titleOne = new Title();
            Console.Write("Введите название книги ");
            titleOne.title = Console.ReadLine();
            
            Author authorOne = new Author();
            Console.Write("Введите автора книги ");
            authorOne.author = Console.ReadLine();
            
            Content contentOne = new Content();
            Console.Write("Введите содержание книги ");
            contentOne.content = Console.ReadLine();
            titleOne.Show();
            authorOne.Show();
            contentOne.Show();
        }
    }
}
