using System;

public class Solution 
{
    public string[] solution(string my_string) 
    {
        return my_string.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
    }
}