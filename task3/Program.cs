using System;

// Interface definition - defines a contract that implementing classes must follow
interface IMovable
{
    // Interface method - no implementation, just the signature
    void Move();
}

// Car class that implements the IMovable interface
class Car : IMovable
{
    private string brand;
    private string model;
    
    // Constructor
    public Car(string brand, string model)
    {
        this.brand = brand;
        this.model = model;
    }
    
    // Implementation of the Move method from IMovable interface
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
    
    // Additional method specific to Car
    public void DisplayInfo()
    {
        Console.WriteLine($"Car: {brand} {model}");
    }
}

// Bicycle class that implements the IMovable interface
class Bicycle : IMovable
{
    private string type;
    private int gears;
    
    // Constructor
    public Bicycle(string type, int gears)
    {
        this.type = type;
        this.gears = gears;
    }
    
    // Implementation of the Move method from IMovable interface
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
    
    // Additional method specific to Bicycle
    public void DisplayInfo()
    {
        Console.WriteLine($"Bicycle: {type} with {gears} gears");
    }
}

// Additional class to demonstrate interface flexibility
class Robot : IMovable
{
    private string name;
    
    public Robot(string name)
    {
        this.name = name;
    }
    
    public void Move()
    {
        Console.WriteLine("Robot is moving");
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Robot: {name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Interfaces Example");
        Console.WriteLine("==================");
        
        // Create instances of Car and Bicycle
        Car car = new Car("Toyota", "Camry");
        Bicycle bicycle = new Bicycle("Mountain Bike", 21);
        
        // Call Move() method on each instance
        Console.WriteLine("\nCalling Move() method on each instance:");
        Console.WriteLine("--------------------------------------");
        
        Console.WriteLine("\nCar instance:");
        car.DisplayInfo();
        car.Move();
        
        Console.WriteLine("\nBicycle instance:");
        bicycle.DisplayInfo();
        bicycle.Move();
        
        // Demonstrating interface polymorphism
        Console.WriteLine("\n--- Interface Polymorphism ---");
        Console.WriteLine("Using IMovable interface reference:");
        
        // Array of IMovable references
        IMovable[] movableObjects = 
        {
            new Car("Honda", "Civic"),
            new Bicycle("Road Bike", 18),
            new Robot("R2D2")
        };
        
        // Call Move() on each object through interface reference
        for (int i = 0; i < movableObjects.Length; i++)
        {
            Console.WriteLine($"\nMovable object {i + 1}:");
            
            // We can call interface methods
            movableObjects[i].Move();
            
            // We can also check the actual type and call specific methods
            if (movableObjects[i] is Car carObj)
            {
                carObj.DisplayInfo();
            }
            else if (movableObjects[i] is Bicycle bikeObj)
            {
                bikeObj.DisplayInfo();
            }
            else if (movableObjects[i] is Robot robotObj)
            {
                robotObj.DisplayInfo();
            }
        }
        
        // Demonstrating interface as parameter
        Console.WriteLine("\n--- Interface as Method Parameter ---");
        MoveVehicle(car);
        MoveVehicle(bicycle);
        MoveVehicle(new Robot("C3PO"));
        
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
    
    // Method that accepts any object implementing IMovable interface
    static void MoveVehicle(IMovable movable)
    {
        Console.WriteLine("Starting movement...");
        movable.Move();
        Console.WriteLine("Movement complete.");
    }
}