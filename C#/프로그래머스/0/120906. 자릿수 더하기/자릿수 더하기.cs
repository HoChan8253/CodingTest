using System;

public class Solution 
{
    public int solution(int n) 
    {
        // 풀이 1
        //int answer = 0;
        //string s = n.ToString();
        //foreach(char c in s)
        //{
        //    answer += c - '0';
        //}
        //return answer;
        
        // 풀이 2
        int answer = 0;
        while(n > 0)
        {
            answer += n % 10;
            n /= 10;
        }
        return answer;
    }
}