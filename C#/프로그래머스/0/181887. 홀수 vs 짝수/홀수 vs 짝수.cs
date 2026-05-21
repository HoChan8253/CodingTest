using System;

public class Solution 
{
    public int solution(int[] num_list) 
    {
        int even = 0; // 짝수
        int odd = 0; // 홀수
        for(int i = 0; i < num_list.Length; i++)
        {
            if((i + 1) % 2 != 0)
            {
                odd += num_list[i];
            }
            else
            {
                even += num_list[i];
            }
        }
        return Math.Max(even, odd);
    }
}