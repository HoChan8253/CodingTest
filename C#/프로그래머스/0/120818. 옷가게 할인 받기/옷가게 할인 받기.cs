using System;

public class Solution 
{
    public int solution(int price) 
    {
        // 이거 왜 통과가 안되는걸까?
        //int discount = price >= 500000 ? price * 20 / 100 :
        //               price >= 300000 ? price * 10 / 100 :
        //               price >= 100000 ? price * 5 / 100 : 0;
        //return price - discount;
        
        // if 문도 안되네?
        //int discount = 0;
        //if(price >= 500000) discount = price * 20 / 100;
        //else if(price >= 300000) discount = price * 10 / 100;
        //else if(price >= 100000) discount = price * 5 / 100;
        //return price - discount;
        
        double rate = price >= 500000 ? 0.8 :
                      price >= 300000 ? 0.9 :
                      price >= 100000 ? 0.95 : 1.0;
        return (int)(price * rate);
    }
}