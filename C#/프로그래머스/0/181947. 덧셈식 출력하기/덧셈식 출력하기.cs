using System;

public class Example
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();

        int a = Int32.Parse(input[0]);
        int b = Int32.Parse(input[1]);

        Console.WriteLine($"{a} + {b} = {a + b}");
    }
}