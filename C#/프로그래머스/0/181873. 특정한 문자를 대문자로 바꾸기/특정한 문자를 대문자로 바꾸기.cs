using System;
using System.Collections.Generic;

public class Solution 
{
    public string solution(string my_string, string alp) 
    {
        List <char> answer = new List <char>();
        foreach(char c in my_string)
        {
            if(c == alp[0])
            {
                answer.Add(char.ToUpper(c));
            }
            else
            {
                answer.Add(c);
            }
        }
        return new string(answer.ToArray());
    }
}