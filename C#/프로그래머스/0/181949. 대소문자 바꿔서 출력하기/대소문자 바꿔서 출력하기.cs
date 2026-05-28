using System;

public class Example
{
    public static void Main()
    {
        String answer = "";
        String s = Console.ReadLine();
        foreach(char c in s)
        {
            if(char.IsLower(c)) answer += char.ToUpper(c);
            else answer += char.ToLower(c);
        }
        Console.WriteLine(answer);
    }
}