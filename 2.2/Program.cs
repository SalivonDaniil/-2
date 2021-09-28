using System;

namespace _2._2
{
    class Rectangle
    {
        private double _side1;
        private double _side2;

        public double side1
        {
            get
            {
                return _side1;
            }
            set
            {
                this._side1 = value;
            }
        }
        public double side2
        {
            get
            {
                return _side2;
            }
            set
            {
                this._side2 = value;
            }
        }

        public Rectangle()
        {
            this._side1 = 0;
            this._side2 = 0;
        }
        public Rectangle(double side1)
        {
            this._side1 = side1;
            this._side2 = 0;
        }
        public Rectangle(double side1, double side2)
        {
            this._side1 = side1;
            this._side2 = side2;
        }

        
        public double AreaCalculator()
        {
            return side1 * side2;
            
        }
        public double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
            
        }

        public double Area
        {
            get
            {
                return this.AreaCalculator();
            }
        }
        public double Perimeter
        {
            get
            {
                return this.PerimeterCalculator();
            }
        }
        public void GetInfo()
        {
            Console.WriteLine($"Площадь: {Area} Периметр: {Perimeter}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle RectangleOne = new Rectangle();
            Console.Write("Введите длинну 1 стороны прямоугольника ");
            RectangleOne.side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длинну 2 стороны прямоугольника ");
            RectangleOne.side2 = Convert.ToInt32(Console.ReadLine());
            RectangleOne.GetInfo();
        }
    }
}
