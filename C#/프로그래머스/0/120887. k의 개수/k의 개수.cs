using System;

public class Solution 
{
    public int solution(int i, int j, int k) 
    {
        int count = 0;
        char target = k.ToString()[0];
        
        for(int num = i; num <= j; num++)
        {
            string str = num.ToString();
            foreach(char c in str)
            {
                if(c == target) count++;
            }
        }
        
        return count;
    }
}