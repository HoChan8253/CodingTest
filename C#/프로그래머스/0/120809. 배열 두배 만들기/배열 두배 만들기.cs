using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] numbers) 
    {
        List <int> answer = new List <int> ();
        foreach(int i in numbers)
        {
            answer.Add(i * 2);
        }
        return answer.ToArray();
    }
}