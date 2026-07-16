using System;
using System.Text;

public class Solution 
{
    public string solution(string s) 
    {
        // 풀이 1
        string answer = "";
        int idx = 0;
        
        foreach(char c in s)
        {
            if(c == ' ')
            {
                answer += " ";
                idx = 0;
            }
            else
            {
                if(idx % 2 == 0) answer += char.ToUpper(c);
                else answer += char.ToLower(c);
                idx++;
            }
        }
        return answer;
    }
}