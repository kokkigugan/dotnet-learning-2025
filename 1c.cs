using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Data:");
        int? age =Convert.ToInt32(Console.ReadLine());
        string? name = Console.ReadLine();
        double? height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Hello, {name}! You are {age} years old and {height} cm tall.");
    }
}