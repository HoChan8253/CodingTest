using System;

public class Solution 
{
    public int solution(int[] num_list) 
    {
        int count = 0;
        
        foreach(int number in num_list)
        {
            int num = number;          
            while(num != 1)
            {
                if(num % 2 == 0) num /= 2;
                else num = (num - 1) / 2;
                count++;
            }
        }
        return count;
    }
}