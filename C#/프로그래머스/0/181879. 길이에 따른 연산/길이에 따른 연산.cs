using System;

public class Solution 
{
    public int solution(int[] num_list) 
    {
        int answer;
        if(num_list.Length >= 11)
        {
            answer = 0;
            foreach(int i in num_list)
            {
                answer += i;    
            }
            return answer;
        }
        else
        {
            answer = 1;
            foreach(int i in num_list)
            {
                answer *= i;
            }
        }
        return answer;
    }
}