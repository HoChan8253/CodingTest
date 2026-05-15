using System;
using System.Linq;

public class Solution 
{
    public int solution(string[] s1, string[] s2) 
    {
        int answer = 0;
        for(int i = 0; i < s2.Length; i++)
        {
            if(s1.Contains(s2[i]))
            {
                answer++;
            }
        }
        return answer;
    }
}