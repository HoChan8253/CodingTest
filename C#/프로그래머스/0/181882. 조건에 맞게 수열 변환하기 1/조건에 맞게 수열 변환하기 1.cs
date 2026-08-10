using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] arr) 
    {
        List <int> answer = new List <int> ();
        
        foreach(int i in arr)
        {
            if(i % 2 == 0 && i >= 50)
            {
                answer.Add(i / 2);
            }
            else if(i % 2 != 0 && i < 50)
            {
                answer.Add(i * 2);
            }
            else
            {
                answer.Add(i);
            }
        }
        
        return answer.ToArray();
    }
}