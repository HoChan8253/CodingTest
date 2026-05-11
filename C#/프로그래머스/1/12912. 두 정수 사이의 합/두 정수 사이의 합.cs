using System;

public class Solution 
{
    public long solution(int a, int b) 
    {
        // 풀이 1 - 반복문 사용
        long answer = 0;
        
        for(int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
        {
            answer += i;
        }
        
        return answer;
        
        // 풀이 2 - 등차수열 사용
        //long min = Math.Min(a, b);
        //long max = Math.Max(a, b);
        //return (min + max) * (max - min + 1) / 2;
        
        //return ((long)(Math.Abs(a - b) + 1) * (a + b)) / 2;
    }
}