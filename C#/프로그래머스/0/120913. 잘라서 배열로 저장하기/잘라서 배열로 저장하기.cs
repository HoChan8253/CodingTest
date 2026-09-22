using System;

public class Solution 
{
    public string[] solution(string my_str, int n) 
    {
        int length = (my_str.Length + n - 1) / n;
        string[] answer = new string[length];
        
        for (int i = 0; i < length; i++)
        {
            int start = i * n;
            int count = Math.Min(n, my_str.Length - start);
            
            answer[i] = my_str.Substring(start, count);
        }
        
        return answer;
    }
}