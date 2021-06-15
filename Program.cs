using System;
using Models;
using Bogus;
using System.Collections.Generic;

namespace TestWork
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> randomList = new List<Shape>();

            var testCircles = new Faker<Circle>()
                .CustomInstantiator(f => new Circle(
                    f.PickRandom<Color>()
                    .ToString(),
                    Convert.ToDouble(f.Random.Byte())));
            var circles = testCircles.Generate(5);
            randomList.AddRange(circles);

            var testTrapeziums = new Faker<Trapezium>()
                .CustomInstantiator(f => new Trapezium(
                    f.PickRandom<Color>().ToString(), 
                    Convert.ToDouble(f.Random.Byte()),
                    Convert.ToDouble(f.Random.Byte()),
                    Convert.ToDouble(f.Random.Byte())));
            var trapeziums = testTrapeziums.Generate(5);
            randomList.AddRange(trapeziums);

            var testSquares = new Faker<Square>()
                .CustomInstantiator(f => new Square(
                    f.PickRandom<Color>().ToString(),
                    Convert.ToDouble(f.Random.Byte())));
            var squares = testSquares.Generate(5);
            randomList.AddRange(squares);

            var testRightTriangle = new Faker<RightTriangle>()
                .CustomInstantiator(f => new RightTriangle(
                    f.PickRandom<Color>().ToString(),
                    Convert.ToDouble(f.Random.Byte()),
                    Convert.ToDouble(f.Random.Byte())));
            var triangles = testRightTriangle.Generate(5);
            randomList.AddRange(triangles);
            randomList.Shuffle();
            
            foreach(var shape in randomList)
            {
                Console.WriteLine(shape.ToString());
            }
        }
    }
    
    public enum Color
    {
        Red,
        Black,
        Green, 
        Grey,
        Gold
    }
}
