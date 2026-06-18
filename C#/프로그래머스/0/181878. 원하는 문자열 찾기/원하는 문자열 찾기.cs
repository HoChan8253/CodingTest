using System;

public class Solution 
{
    public int solution(string myString, string pat) 
    {
        string ms = myString.ToLower();
        string find = pat.ToLower();
        return ms.Contains(find) ? 1 : 0;
    }
}