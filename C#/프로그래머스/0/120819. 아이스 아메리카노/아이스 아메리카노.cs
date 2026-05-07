using System;

public class Solution 
{
    public int[] solution(int money) 
    {
        const int COFFEE_COST = 5500;
        return new int[] {money / COFFEE_COST , money % COFFEE_COST};
    }
}