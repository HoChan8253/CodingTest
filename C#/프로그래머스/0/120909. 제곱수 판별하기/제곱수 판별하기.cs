using System;

public class Solution 
{
    public int solution(int n) 
    {
        double sqrt = Math.Sqrt(n);
        if(sqrt == (int)sqrt) return 1;
        return 2;
    }
}