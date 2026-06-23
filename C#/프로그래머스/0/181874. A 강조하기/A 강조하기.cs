using System;

public class Solution 
{
    public string solution(string myString) 
    {
        string answer = "";
        foreach(char c in myString)
        {
            char lower = char.ToLower(c);
            if(lower == 'a') answer += 'A';
            else answer += lower;
        }
        return answer;
    }
}