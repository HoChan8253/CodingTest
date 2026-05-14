using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(long n) 
    {
        // 풀이 1
        //string s = n.ToString();
        //List<int> answer = new List<int>();
        //for(int i = s.Length - 1; i >= 0; i--)
        //{
        //    answer.Add(s[i] - '0');
        //}
        //return answer.ToArray();
        
        // 풀이 2
        List<int> answer = new List<int>();
        while(n > 0)
        {
            answer.Add((int)(n % 10));
            n /= 10;
        }
        return answer.ToArray();
    }
}