using System;

public class Solution 
{
    public int solution(string my_string) 
    {
        string[] parts = my_string.Split(' ');
        int answer = int.Parse(parts[0]);
        
        for(int i = 1; i < parts.Length; i += 2)
        {
            if(parts[i] == "+") answer += int.Parse(parts[i + 1]);
            else answer -= int.Parse(parts[i + 1]);
        }
        
        return answer;
    }
}