using System;

namespace _05._05._22
{
    abstract class Polygon
    {
        public abstract double GetArea();
    }
    class Square : Polygon
    {
        private double _side;
        public Square(double side)
        {
            _side = side;
        }
        public override double GetArea() => _side * _side;
    }
    class Triangle : Polygon
    {
        protected double _sideOne, _sideTwo, _sideThree;
        public Triangle(double sideOne, double sideTwo, double sideThree)
        {
            _sideOne = sideOne;
            _sideTwo = sideTwo;
            _sideThree = sideThree;
        }
        private double HalfPerimetr() => (_sideOne + _sideTwo + _sideThree) / 2;
        public override double GetArea() => Math.Sqrt(HalfPerimetr() * (HalfPerimetr() - _sideOne)
            * (HalfPerimetr() - _sideTwo) * (HalfPerimetr() - _sideThree));
    }
    class RightTriangle : Triangle
    {
        public RightTriangle(double sideOne, double sideTwo, double sideThree) // sideOne - гипотенуза
            : base(sideOne, sideTwo, sideThree) { }
        public override double GetArea() => (_sideTwo * _sideThree) / 2;
    }
}
