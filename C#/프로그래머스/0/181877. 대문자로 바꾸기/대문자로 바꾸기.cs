using System;

public class Solution 
{
    public string solution(string myString) 
    {
        string answer = "";
        foreach(char c in myString)
        {
            answer += char.IsLower(c) ? char.ToUpper(c) : c;
        }
        return answer;
    }
}