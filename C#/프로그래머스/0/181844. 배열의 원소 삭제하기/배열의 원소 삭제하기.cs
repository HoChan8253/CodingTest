using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] arr, int[] delete_list) 
    {
        List <int> answer = new List <int>();
        foreach(int i in arr)
        {
            if(delete_list.Contains(i))
            {
                continue;
            }
            answer.Add(i);
        }
        return answer.ToArray();
    }
}