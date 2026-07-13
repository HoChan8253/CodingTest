using System;

public class Solution 
{
    public int solution(int a, int b) 
    {
        int ab = int.Parse(a.ToString() + b.ToString());
        int ba = int.Parse(b.ToString() + a.ToString());
        return Math.Max(ab, ba);
    }
}