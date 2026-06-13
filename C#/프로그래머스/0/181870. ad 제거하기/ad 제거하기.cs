using System;
using System.Collections.Generic;

public class Solution 
{
    public string[] solution(string[] strArr) 
    {
        List<string> answer = new List<string>();
        foreach(string c in strArr)
        {
            if(c.Contains("ad"))
            {
                continue;
            }
            answer.Add(c);
        }
        return answer.ToArray();
    }
}