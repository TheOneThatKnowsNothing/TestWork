using System;

namespace Models
{
    public class RightTriangle:Shape
    {
        public double FirstCathetus{get;set;}
        public double SecondCathetus{get;set;}
        public double Hypotenuse => Math.Sqrt(FirstCathetus*FirstCathetus+SecondCathetus*SecondCathetus);
        public override double Perimeter => FirstCathetus+SecondCathetus+Hypotenuse;
        public override double Area => (FirstCathetus*SecondCathetus)/2;

        public override string ToString()
        {
            return base.ToString()+$" first cathetus: {FirstCathetus}, second cathetus {SecondCathetus}, hypothenuse: {Hypotenuse}.";
        }
        public RightTriangle(string color, double firstCathetus, double secondCatheus)
        {
            Color=color;
            FirstCathetus=firstCathetus;
            SecondCathetus=secondCatheus;
        }
    }
}