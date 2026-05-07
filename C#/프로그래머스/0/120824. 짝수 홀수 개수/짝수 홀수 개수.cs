using System;

public class Solution 
{
    public int[] solution(int[] num_list) 
    {
        int even = 0; // 짝수
        int odd = 0; // 홀수
        
        foreach(int num in num_list)
        {
            if(num % 2 == 0) even++;
            else odd++;
        }

        return new int[] {even, odd};
    }
}