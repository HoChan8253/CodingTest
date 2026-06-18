using System;

public class Solution 
{
    public int solution(string myString, string pat) 
    {
        int answer = 0;
        string ms = myString.ToLower();
        string find = pat.ToLower();
        if(ms.Contains(find))
        {
            answer = 1;
        }
        else
        {
            answer = 0;
        }
        return answer;
    }
}