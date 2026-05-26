using System;

public class Solution 
{
    public int solution(string[] order) 
    {
        int answer = 0;
        foreach(string s in order)
        {
            if(s.Contains("americano") || s.Contains("anything"))
            {
                answer += 4500;
            }
            if(s.Contains("cafelatte"))
            {
                answer += 5000;
            }
        }
        return answer;
    }
}