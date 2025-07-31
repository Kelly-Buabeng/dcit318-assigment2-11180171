using System;

// Base class Animal
class Animal
{
    // Virtual method that can be overridden in derived classes
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

// Derived class Dog that inherits from Animal
class Dog : Animal
{
    // Override the MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

// Derived class Cat that inherits from Animal
class Cat : Animal
{
    // Override the MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Inheritance and Method Overriding Example");
        Console.WriteLine("=========================================");
        
        // Create instances of Animal, Dog, and Cat
        Animal animal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();
        
        // Call MakeSound() method on each instance
        Console.WriteLine("\nCalling MakeSound() on Animal instance:");
        animal.MakeSound();
        
        Console.WriteLine("\nCalling MakeSound() on Dog instance:");
        dog.MakeSound();
        
        Console.WriteLine("\nCalling MakeSound() on Cat instance:");
        cat.MakeSound();
        
        // Demonstrating polymorphism - base class reference to derived objects
        Console.WriteLine("\n--- Polymorphism Example ---");
        Animal[] animals = { new Animal(), new Dog(), new Cat() };
        
        for (int i = 0; i < animals.Length; i++)
        {
            Console.Write($"Animal {i + 1}: ");
            animals[i].MakeSound();
        }
        
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}