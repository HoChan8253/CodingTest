using System;

public class Solution 
{
    public int solution(int price)
    {
        float offPrice = price;
        if (price >= 500000)      offPrice = price - (price * 0.2f);
        else if (price >= 300000) offPrice = price - (price * 0.1f);
        else if (price >= 100000) offPrice = price - (price * 0.05f);
        return (int)offPrice;
    }
}