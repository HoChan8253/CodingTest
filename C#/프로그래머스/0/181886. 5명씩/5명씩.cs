using System;
using System.Collections.Generic;

public class Solution 
{
    public string[] solution(string[] names) 
    {
        List <string> answer = new List <string> ();
        int count = 5;
        for(int i = 0; i < names.Length; i += count)
        {
            answer.Add(names[i]);
        }
        return answer.ToArray();
    }
}