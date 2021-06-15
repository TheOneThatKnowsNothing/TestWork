namespace Models
{
    public class Trapezium : Shape
    {
        public double Abasis {get;set;}
        public double Bbasis {get;set;}
        public double Height {get;set;}
        public override double Area => (Abasis+Bbasis)/2*Height;
        public Trapezium(string color, double a, double b, double height)
        {
            Color=color;
            Abasis=a;
            Bbasis=b;
            Height=height;
        }
        public override string ToString()
        {
            return $"Shape is {this.GetType().Name}, color: {Color}, area: {Area}, height {Height}.";
        }  
    }
}