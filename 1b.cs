using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name :");
        string? name =Console.ReadLine();
        Console.WriteLine($"Your name {name}");
    }
}