using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] num_list, int n) 
    {
        List <int> answer = new List <int> ();
        for(int i = n; i < num_list.Length + 1; i++)
        {
            answer.Add(num_list[i - 1]);
        }
        return answer.ToArray();
    }
}