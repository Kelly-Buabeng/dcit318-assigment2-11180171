using System;

// Abstract base class Shape
abstract class Shape
{
    // Abstract method that must be implemented by derived classes
    public abstract double GetArea();
    
    // Optional: You can also have concrete methods in abstract classes
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Area: {GetArea():F2} square units");
    }
}

// Derived class Circle that inherits from Shape
class Circle : Shape
{
    private double radius;
    
    // Constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }
    
    // Implementation of the abstract GetArea method
    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
    
    // Override DisplayInfo to provide more specific information
    public override void DisplayInfo()
    {
        Console.WriteLine($"Circle with radius {radius:F2}");
        base.DisplayInfo();
    }
}

// Derived class Rectangle that inherits from Shape
class Rectangle : Shape
{
    private double width;
    private double height;
    
    // Constructor
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    
    // Implementation of the abstract GetArea method
    public override double GetArea()
    {
        return width * height;
    }
    
    // Override DisplayInfo to provide more specific information
    public override void DisplayInfo()
    {
        Console.WriteLine($"Rectangle with width {width:F2} and height {height:F2}");
        base.DisplayInfo();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Abstract Classes and Methods Example");
        Console.WriteLine("===================================");
        
        // Create instances of Circle and Rectangle
        Circle circle = new Circle(5.0);
        Rectangle rectangle = new Rectangle(4.0, 6.0);
        
        // Display their areas
        Console.WriteLine("\nCalculating and displaying areas:");
        Console.WriteLine("--------------------------------");
        
        Console.WriteLine("\nCircle Information:");
        circle.DisplayInfo();
        Console.WriteLine($"Area calculation: π × {5.0}² = {circle.GetArea():F2}");
        
        Console.WriteLine("\nRectangle Information:");
        rectangle.DisplayInfo();
        Console.WriteLine($"Area calculation: {4.0} × {6.0} = {rectangle.GetArea():F2}");
        
        // Demonstrating polymorphism with abstract class reference
        Console.WriteLine("\n--- Polymorphism with Abstract Classes ---");
        Shape[] shapes = { new Circle(3.0), new Rectangle(2.5, 8.0), new Circle(7.2) };
        
        for (int i = 0; i < shapes.Length; i++)
        {
            Console.WriteLine($"\nShape {i + 1}:");
            shapes[i].DisplayInfo();
        }
        
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}