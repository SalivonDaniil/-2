using System;

namespace _2._7
{
    class Employee
    {
        private string _name;
        private string _surname;
        private int _position;
        private string _position1;
        private int _pay;
        private int _time;
        private int _tax;

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
        public int position
        {
            get
            {
                return _position;
            }
            set
            {
                this._position = value;
            }
        }
        public string position1
        {
            get
            {
                return _position1;
            }
            set
            {
                this._position1 = value;
            }
        }
        public int pay
        {
            get
            {
                return _pay;
            }
            set
            {
                this._pay = value;
            }
        }
        public int time
        {
            get
            {
                return _time;
            }
            set
            {
                this._time = value;
            }
        }
        public int tax
        {
            get
            {
                return _tax;
            }
            set
            {
                this._tax = value;
            }
        }
        public Employee()
        {
            this._name = "-";
            this._surname = "-";
            this._position = 1;
            this._time = 1;
        }
        public Employee(string name)
        {
            this._name = name;
            this._surname = "-";
            this._position = 1;
            this._time = 1;
        }
        public Employee(string name, string surname)
        {
            this._name = name;
            this._surname = surname;
            this._position = 1;
            this._time = 1;
        }
        public Employee(string name, string surname, int position)
        {
            this._name = name;
            this._surname = surname;
            this._position = position;
            this._time = 1;
        }
        public Employee(string name, string surname, int position, int time)
        {
            this._name = name;
            this._surname = surname;
            this._position = position;
            this._time = time;
        }

        public void GetInfo()
        {
            if (position == 1)
            {
                pay = 10000 * time;
                tax = pay / 100 * 34;
                position1 = "работник";
            }
            else if (position == 2)
            {
                pay = 20000 * time;
                tax = pay / 100 * 34;
                position1 = "начальник";
            }
            else
            {
                Console.WriteLine("Нужно ввести цифру от 1 до 2");
            }
            Console.WriteLine($"Имя: {name} Фамилия: {surname} Должность: {1} Оклад: {pay} Налоговый сбор: {tax}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeOne = new Employee();
            Console.Write("Введите имя ");
            employeeOne.name = Console.ReadLine();
            Console.Write("Введите фамилию ");
            employeeOne.surname = Console.ReadLine();
            Console.Write("Введите стаж ");
            employeeOne.time = Convert.ToInt32(Console.ReadLine());
            Console.Write("Выберите должность: 1) работник; 2) начальник ");
            employeeOne.position = Convert.ToInt32(Console.ReadLine());
            employeeOne.GetInfo();
        }
    }
}
