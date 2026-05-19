using System;

public class Solution 
{
    public int solution(int order) 
    {
        // 풀이 1
        //int answer = 0;
        //while(order > 0)
        //{
        //    if((order % 10) % 3 == 0 && order % 10 != 0)
        //    {
        //        answer++;
        //    }
        //    order = order / 10;
        //}
        //return answer;
        
        // 풀이 2
        int answer = 0;
        while(order > 0)
        {
            int digit = order % 10;
            if(digit == 3 || digit == 6 || digit == 9)
            {
                answer++;
            }
            order = order / 10;
        }
        return answer;
    }
}