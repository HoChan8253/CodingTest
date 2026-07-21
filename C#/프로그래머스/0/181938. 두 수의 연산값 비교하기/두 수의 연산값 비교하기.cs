using System;

public class Solution 
{
    public int solution(int a, int b) 
    {
        int num = int.Parse(a.ToString() + b.ToString());
        return Math.Max(num, 2 * a * b);
    }
}