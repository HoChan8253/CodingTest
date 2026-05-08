using System;

public class Solution 
{
    public int solution(int n, int k) 
    {
        //int service = n / 10 * 2000;
        //int drink = k * 2000;
        //int food = n * 12000;
        //return food + drink - service;

        return n * 12000 + k * 2000 - n / 10 * 2000;
    }
}