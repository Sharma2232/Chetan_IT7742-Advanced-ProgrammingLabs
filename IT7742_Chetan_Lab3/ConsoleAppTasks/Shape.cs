using System;

abstract class Shape
{
    public abstract double Area { get; }
    public void Display()
    {
        Console.WriteLine("Area: " + Area);
    }
}
