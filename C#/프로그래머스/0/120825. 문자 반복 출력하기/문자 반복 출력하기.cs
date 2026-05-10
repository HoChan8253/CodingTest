using System;

public class Solution 
{
    public string solution(string my_string, int n) 
    {
        string answer = "";
        foreach(char c in my_string)
        {
            int count = 0;
            while(count < n)
            {
                answer += c;
                count++;
            }
        }
        return answer;
    }
}