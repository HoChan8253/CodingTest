using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int start_num, int end_num) 
    {
        List<int> answer = new List<int>();
        int maxNum = Math.Max(start_num, end_num);
        int minNum = Math.Min(start_num, end_num);
        for(int i = maxNum; i >= minNum; i--)
        {
            answer.Add(i);
        }
        return answer.ToArray();
    }
}