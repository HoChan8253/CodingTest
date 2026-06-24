using System;

public class Solution 
{
    public string solution(string my_string) 
    {
        string answer = "";
        for(int i = 0; i < my_string.Length; i++)
        {
            if(answer.Contains(my_string[i])) continue;
            answer += my_string[i];
        }
        return answer;
    }
}