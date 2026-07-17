using System;

public class Example
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        Console.WriteLine(parts[0] + parts[1]);
    }
}