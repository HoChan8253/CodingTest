using System;

public class Solution 
{
    public int solution(int n) 
    {
        // 풀이 1
        //int answer = 0;
        //for(int i = 1; i <= n; i++)
        //{
        //    if(n % i == 0)
        //    {
        //        answer++;
        //    }
        //}
        //return answer;
        
        // 풀이 2
        int answer = 0;
        for(int i = 1; i <= Math.Sqrt(n); i++)
        {
            if(n % i == 0)
            {
                if(i == n / i)
                {
                    answer++;
                }
                else
                {
                    answer += 2;
                }
            }
        }
        return answer;
    }
}