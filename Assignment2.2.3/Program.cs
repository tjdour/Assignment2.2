//assignment223

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculate Area");
        Console.WriteLine("1. Circle");
        Console.WriteLine("2. Square");
        Console.Write("Enter choice: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the shape ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the shape color: ");
        string color = Console.ReadLine()!;

        Shape shape;

        if (choice == 1)
        {
            Console.Write("Enter the circle radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            shape = new Circle
            {
                Id = id,
                Name = "Circle",
                Color = color,
                Radius = radius
            };
        }
        else if (choice == 2)
        {
            Console.Write("Enter the square side length: ");
            double sideLength = Convert.ToDouble(Console.ReadLine());

            shape = new Square
            {
                Id = id,
                Name = "Square",
                Color = color,
                SideLength = sideLength
            };
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("Shape Information");
        Console.WriteLine($"ID: {shape.Id}");
        Console.WriteLine($"Name: {shape.Name}");
        Console.WriteLine($"Color: {shape.Color}");
        Console.WriteLine($"Area: {shape.CalculateArea():F2}");
    }
}

public abstract class Shape
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Color { get; set; } = string.Empty;

    public abstract double CalculateArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Square : Shape
{
    public double SideLength { get; set; }

    public override double CalculateArea()
    {
        return SideLength * SideLength;
    }
}
