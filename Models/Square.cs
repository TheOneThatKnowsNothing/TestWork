namespace Models
{
    public class Square: Shape
    {
        public double SideLength {get;set;}

        public override double Area => SideLength*SideLength;

        public override double Perimeter => SideLength*4;

        public Square(string color, double sideLength)
        {
            Color=color;
            SideLength=sideLength;
        }
        public override string ToString()
        {
            return base.ToString()+$" side length: {SideLength}.";
        }
    }
}