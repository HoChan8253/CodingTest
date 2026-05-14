using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(long n) 
    {
        string s = n.ToString();
        List<int> answer = new List<int>();
        for(int i = s.Length - 1; i >= 0; i--)
        {
            answer.Add(s[i] - '0');
        }
        return answer.ToArray();
    }
}