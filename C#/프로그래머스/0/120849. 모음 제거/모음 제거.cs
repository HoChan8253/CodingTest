using System;

public class Solution 
{
    public string solution(string my_string) 
    {
        foreach(char c in "aeiou")
            my_string = my_string.Replace(c.ToString(), "");
        return my_string;
    }
}