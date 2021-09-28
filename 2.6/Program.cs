using System;

namespace _2._6
{
    class Converter
    {
        private double _usd;
        private double _eur;
        private double _rub;
        private double _uah;
        private double _num;
        public double usd
        {
            get
            {
                return _usd;
            }
            set
            {
                this._usd = value;
            }
        }
        public double eur
        {
            get
            {
                return _eur;
            }
            set
            {
                this._eur = value;
            }
        }
        public double rub
        {
            get
            {
                return _rub;
            }
            set
            {
                this._rub = value;
            }
        }
        public double uah
        {
            get
            {
                return _uah;
            }
            set
            {
                this._uah = value;
            }
        }
        public double num
        {
            get
            {
                return _num;
            }
            set
            {
                this._num = value;
            }
        }
        public Converter()
        {
            this._usd = 26.66;
            this._eur = 31.18;
            this._rub = 0.37;
        }
        public void GetInfo()
        {
            if (num == 1) {
                Console.WriteLine(uah * usd);
            }
            else if (num == 2)
            {
                Console.WriteLine(uah * eur);
            }
            else if (num == 3)
            {
                Console.WriteLine(uah * rub);
            }
            else if (num == 4)
            {
                Console.WriteLine(usd * uah);
            }
            else if (num == 5)
            {
                Console.WriteLine(eur * uah);
            }
            else if (num == 6)
            {
                Console.WriteLine(rub * uah);
            }
            else
            {
                Console.WriteLine("введите число от 1 до 6");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Converter converterOne = new Converter();
            Console.WriteLine("Введите номер для выбора типа конвертации: ");
            Console.WriteLine("1) UAH -> USD");
            Console.WriteLine("2) UAH -> EUR");
            Console.WriteLine("3) UAH -> RUB");
            Console.WriteLine("4) USD -> UAH");
            Console.WriteLine("5) EUR -> UAH");
            Console.WriteLine("6) RUB -> UAH");
            converterOne.num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество валюты: ");
            converterOne.uah = Convert.ToInt32(Console.ReadLine());
            converterOne.GetInfo();
        }
    }
}
