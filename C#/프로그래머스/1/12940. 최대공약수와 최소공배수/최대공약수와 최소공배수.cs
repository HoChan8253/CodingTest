using System;

public class Solution 
{
    public int[] solution(int n, int m) 
    {
        int SmallNum = Math.Min(n, m);
        int GCD = 0; // 최대공약수
        for(int i = SmallNum; i >= 1; i--)
        {
            if(n % i == 0 && m % i == 0)
            {
                GCD = i;
                break;
            }
        }
        int LCM = (n * m) / GCD; // 최소공배수
        return new int[] {GCD, LCM};
    }
}