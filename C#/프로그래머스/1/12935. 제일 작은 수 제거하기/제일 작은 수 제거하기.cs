using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] arr) 
    {
        List<int> list = new List<int>(arr);
        int minValue = list.Min();
        list.Remove(minValue);
        if(list.Count == 0)
        {
            list.Clear();
            list.Add(-1);
        }
        arr = list.ToArray();
        return arr;
    }
}