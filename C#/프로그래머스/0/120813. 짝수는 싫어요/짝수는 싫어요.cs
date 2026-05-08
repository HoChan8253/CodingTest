using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int n) 
    {
        // 풀이 1 - Array 사용
        
        //int[] answer = new int[(n + 1) / 2];
        //int idx = 0;
        //for(int i = 1; i <= n; i++)
        //{
        //   if(i % 2 != 0)
        //    {
        //        answer[idx] = i;
        //        idx++;
        //    }
        //}
        //return answer;
        
        // 풀이 2 - List 사용
        List<int> list = new List<int>();
        
        for(int i = 1; i <= n; i++)
        {
            if(i % 2 != 0) list.Add(i);
        }
        
        return list.ToArray();
    }
}