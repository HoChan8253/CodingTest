using System;

public class Solution 
{
    public string solution(string my_string) 
    {
        char[] answer = my_string.ToLower().ToCharArray();
        Array.Sort(answer);
        return new string(answer);
    }
}