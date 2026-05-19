using System;

public class Solution 
{
    public string solution(string rsp) 
    {
        string r = "0";
        string s = "2";
        string p = "5";
        string answer = "";
        
        foreach(char c in rsp)
        {
            if(c.ToString() == r)
            {
                answer += p;
            }
            else if(c.ToString() == s)
            {
                answer += r;
            }
            else
            {
                answer += s;
            }
        }
        return answer;
    }
}