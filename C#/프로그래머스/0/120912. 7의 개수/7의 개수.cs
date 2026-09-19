using System;

public class Solution 
{
    public int solution(int[] array) 
    {
        int answer = 0;
        
        foreach (int number in array)
        {
            int value = number;
            
            while (value > 0)
            {
                if (value % 10 == 7) answer++;
                value /= 10;
            }
        }
        
        return answer;
    }
}