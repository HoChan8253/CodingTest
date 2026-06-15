using System;

public class Solution 
{
    public int solution(string num_str) 
    {
        int answer = 0;
        foreach(char s in num_str)
        {
            answer += s - '0';
        }
        return answer;
    }
}