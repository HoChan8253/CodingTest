using System;

public class Solution 
{
    public int solution(string myString, string pat) 
    {
        string changed = myString.Replace("A", "X")
                                 .Replace("B", "A")
                                 .Replace("X", "B");
        
        return changed.Contains(pat) ? 1 : 0;
    }
}