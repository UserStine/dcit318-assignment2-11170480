using Assignment_2.Abstract.Assignment2.Abstrac;
using Assignment_2.Inheritance.Assignment2.Inheritance;
using Assignment_2.Interface.Assignment2.Interfaces;
using System;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ===== Inheritance Example =====
            Console.WriteLine("=== Inheritance and Method Overriding ===");
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            Console.Write("Animal: ");
            animal.MakeSound();

            Console.Write("Dog: ");
            dog.MakeSound();

            Console.Write("Cat: ");
            cat.MakeSound();

            Console.WriteLine();

            // ===== Abstract Classes Example =====
            Console.WriteLine("=== Abstract Classes and Methods ===");
            Shape circle = new Circle(5);          // radius 5
            Shape rectangle = new Rectangle(4, 6); // length 4, width 6

            Console.WriteLine($"Circle Area: {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F2}");

            Console.WriteLine();

            // ===== Interfaces Example =====
            Console.WriteLine("=== Interfaces ===");
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            car.Move();
            bicycle.Move();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
