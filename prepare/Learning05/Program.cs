using System;

class Program
{
    static void Main(string[] args)
    {
        // Square s1 = new Square("Purple", 5);

        // Console.WriteLine($"Color {s1.GetColor()}. Area {s1.GetArea()}");


        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Purple", 5);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Green", 5, 2);
        shapes.Add(s2);

        Circle s3 = new Circle("Red", 4);
        shapes.Add(s3);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();
            
            Console.WriteLine($"Color: {color}. Area: {area}");
        }

    }
}