using System;

namespace _2._5
{
    class User
    {
        private string _login;
        private string _name;
        private string _surname;
        private int _age;
        public readonly DateTime date;

        public string login
        {
            get
            {
                return _login;
            }
            set
            {
                this._login = value;
            }
        }
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                this._name = value;
            }
        }
        public string surname
        {
            get
            {
                return _surname;
            }
            set
            {
                this._surname = value;
            }
        }
        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                this._age = value;
            }
        }
        public User()
        {
            date = DateTime.Now;    
        }

        public void GetInfo()
        {
            Console.WriteLine($"Логин: {login} Имя: {name} Фамилия: {surname} Возраст: {age} Дата: {date}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User userOne = new User();
            Console.Write("Введите ваш логин ");
            userOne.login = Console.ReadLine();
            Console.Write("Введите ваше имя ");
            userOne.name = Console.ReadLine();
            Console.Write("Введите вашу фамилию ");
            userOne.surname = Console.ReadLine();
            Console.Write("Введите ваш возраст ");
            userOne.age = Convert.ToInt32(Console.ReadLine());
            
            userOne.GetInfo();
        }
    }
}
