using System;

public class Solution 
{
    public int solution(int n) 
    {
        int sum = 0;
        for(; n >= 0; n--)
        {
            if(n % 2 == 0) sum += n;
        }
        return sum;
    }
}