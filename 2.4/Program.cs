using System;

namespace _2._4
{
    class Point
    {
        private int _side;
        private int _points;
        private string _type;
        public int side
        {
            get
            {
                return _side;
            }
            set
            {
                this._side = value;
            }
        }
        public int points
        {
            get
            {
                return _points;
            }
            set
            {
                this._points = value;
            }
        }
        public string type
        {
            get
            {
                return _type;
            }
        }
        public Point()
        {
            this._side = 1;
            this._points = 3;
        }
        public Point(int side)
        {
            this._side = side;
            this._points = 3;
        }
        public Point(int side, int points)
        {
            this._side = side;
            this._points = points;
        }
        public void Show()
        {
            
        }
    }
    class Figure
    {
        
        public int PerimeterCalculator()
        {
            return side * points;

        }
       
        public int Perimeter
        {
            get
            {
                return this.PerimeterCalculator();
            }
        }
        public void GetInfo()
        {
            Console.WriteLine($"Тип: {points}-угольник; Периметр: {Perimeter}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point pointOne = new Point();
            Console.Write("Введите количество углов (не меньше 3) многоугольника ");
            pointOne.points = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длинну стороны многоугольника ");
            pointOne.side = Convert.ToInt32(Console.ReadLine());
            RectangleOne.GetInfo();
        }
    }
}
