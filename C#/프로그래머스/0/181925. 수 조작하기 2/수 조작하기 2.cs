using System;
using System.Collections.Generic;

public class Solution 
{
    public string solution(int[] numLog) 
    {
        List <char> answer = new List <char> ();
        
        for(int i = 0; i < numLog.Length - 1; i++)
        {
            int diff = numLog[i + 1] - numLog[i];
            
            if(diff == 1) answer.Add('w');
            else if(diff == -1) answer.Add('s');
            else if(diff == 10) answer.Add('d');
            else answer.Add('a');
        }
        
        return new string(answer.ToArray());
    }
}