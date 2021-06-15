namespace Models
{
    public abstract class Shape
    {
        public string Color {get;set;}
        public virtual double Area{get;}
        public virtual double Perimeter{get;}

        public override string ToString()
        {
            return $"Shape is {this.GetType().Name}, color: {Color}, area: {Area}, perimeter: {Perimeter},";
        }
    }
}