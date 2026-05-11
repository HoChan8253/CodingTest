using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    // 풀이 1 - List 사용
    public int[] solution(int n) 
    {
        List<int> list = new List<int>();
        for(int i = 1; i <= n; i++)
        {
            if(n % i == 0)
            {
                list.Add(i);
            }
        }
        return list.ToArray();
    }
    
    // 풀이 2 - LINQ 사용
    //return Enumerable.Range(1, n).Where(i => n % i == 0).ToArray();
}