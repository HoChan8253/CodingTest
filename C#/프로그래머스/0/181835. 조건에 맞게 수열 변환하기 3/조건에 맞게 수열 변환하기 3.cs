using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] arr, int k) 
    {
        List <int> answer = new List <int> ();
        
        for(int i = 0; i < arr.Length; i++)
        {
            if(k % 2 == 0) answer.Add(arr[i] + k);
            else answer.Add(arr[i] * k);
        }
        
        return answer.ToArray();
    }
}