namespace MethodOverriding
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public virtual void Draw()
        {
            // Default implementation
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a rectangle");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a triangle");
        }
    }
}
