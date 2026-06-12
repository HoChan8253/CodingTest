using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] arr) 
    {
        List<int> answer = new List<int>();
        for(int i = 0; i < arr.Length; i++)
        {
            int count = 0;
            while(count < arr[i])
            {
                answer.Add(arr[i]);
                count++;
            }
        }
        return answer.ToArray();
    }
}