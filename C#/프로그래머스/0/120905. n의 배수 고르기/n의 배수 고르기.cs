using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int n, int[] numlist) 
    {
        List<int> list = new List<int>();
        foreach(int i in numlist)
        {
            if(i % n == 0)
            {
                list.Add(i);
            }
        }
        return list.ToArray();
    }
}