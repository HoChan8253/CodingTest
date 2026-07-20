using System;

public class Solution
{
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
}