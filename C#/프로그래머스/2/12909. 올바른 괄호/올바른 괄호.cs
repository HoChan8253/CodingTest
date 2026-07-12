using System;

public class Solution 
{
    public bool solution(string s) 
    {
        int count = 0;
        foreach(char c in s)
        {
            if(count < 0) return false;
            
            count += (c == '(') ? 1 : -1;
        }
        if(count == 0) return true;
        else return false;
    }
}