using System;

public class Solution 
{
    public long solution(string numbers) 
    {
        string[] words =
        {
            "zero", "one", "two", "three", "four",
            "five", "six", "seven", "eight", "nine"
        };
        
        for (int i = 0; i < words.Length; i++)
        {
            numbers = numbers.Replace(words[i], i.ToString());
        }
        
        return long.Parse(numbers);
    }
}