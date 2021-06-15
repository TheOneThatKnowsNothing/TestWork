using System;
namespace Models
{
    public class Circle : Shape
    {
        public double Radius {get;set;}
        public double Diameter => Radius*2;

        public override double Area=> Radius*Radius*Math.PI;

        public override double Perimeter => Diameter*Math.PI;

        public override string ToString()
        {
            return base.ToString()+$" radius: {Radius}, diameter: {Diameter}.";
        }
        public Circle(string color, double radius)
        {
            Color=color;
            Radius=radius;
        }
    }
}