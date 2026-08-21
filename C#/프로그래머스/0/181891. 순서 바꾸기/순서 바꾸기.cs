using System;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] num_list, int n) 
    {
        // 풀이 1 - for문
        //int[] answer = new int[num_list.Length];
        //int index = 0;
        //
        //for(int i = n; i < num_list.Length; i++)
        //{
        //    answer[index] = num_list[i];
        //    index++;
        //}
        //
        //for(int i = 0; i < n; i++)
        //{
        //    answer[index] = num_list[i];
        //    index++;
        //}
        //
        //return answer;
        
        // 풀이 2 - LINQ
        return num_list.Skip(n).Concat(num_list.Take(n)).ToArray();
    }
}