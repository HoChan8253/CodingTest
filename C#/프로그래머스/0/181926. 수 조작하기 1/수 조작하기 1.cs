using System;

public class Solution 
{
    public int solution(int n, string control) 
    {
        int answer = n;
        foreach(char i in control)
        {
            if(i == 'w') answer += 1;
            else if(i == 's') answer -= 1;
            else if(i == 'd') answer += 10;
            else if(i == 'a') answer -= 10;
        }
        return answer;
    }
}