using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] num_list) 
    {
        int last = num_list[num_list.Length - 1];
        int prev = num_list[num_list.Length - 2];
        
        List <int> answer = new List <int> (num_list);
        if(last > prev) answer.Add(last - prev);
        else answer.Add(last * 2);
        
        return answer.ToArray();
    }
}