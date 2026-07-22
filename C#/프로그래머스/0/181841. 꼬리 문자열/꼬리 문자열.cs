using System;

public class Solution 
{
    public string solution(string[] str_list, string ex) 
    {
        string answer = "";
        foreach(string s in str_list)
        {
            if(s.Contains(ex))
            {
                continue;
            }
            answer += s;
        }
        return answer;
    }
}