using System;

public class Solution 
{
    public int solution(int n) 
    {
        int answer = 0;
        string text = n.ToString();
        foreach(char c in text)
        {
            answer += int.Parse(c.ToString());
        }
        return answer;
    }
}