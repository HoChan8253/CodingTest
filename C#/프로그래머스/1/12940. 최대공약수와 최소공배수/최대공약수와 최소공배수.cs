using System;

public class Solution
{
    // 유클리드 호제법
    public int[] solution(int n, int m)
    {
        int gcd = GCD(n, m);
        int lcm = n * m / gcd;

        return new int[] { gcd, lcm };
    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = a % b;
            a = b;
            b = temp;
        }

        return a;
    }
    
    // 처음 풀이
    //public int[] solution(int n, int m) 
    //{
    //    int SmallNum = Math.Min(n, m);
    //    int GCD = 0; // 최대공약수
    //    for(int i = SmallNum; i >= 1; i--)
    //    {
    //        if(n % i == 0 && m % i == 0)
    //        {
    //            GCD = i;
    //            break;
    //        }
    //    }
    //    int LCM = (n * m) / GCD; // 최소공배수
    //    return new int[] {GCD, LCM};
    //}
}