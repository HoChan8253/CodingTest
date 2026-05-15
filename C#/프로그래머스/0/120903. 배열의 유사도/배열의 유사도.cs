using System;
using System.Linq;

public class Solution 
{
    public int solution(string[] s1, string[] s2) 
    {
        // 풀이 1 - LINQ 사용
        //int answer = 0;
        //for(int i = 0; i < s2.Length; i++)
        //{
        //    if(s1.Contains(s2[i]))
        //    {
        //        answer++;
        //   }
        //}
        //return answer;
        
        // 풀이 2 - 반복문 사용
        int answer = 0;
        for(int i = 0; i < s1.Length; i++)
        {
            for(int j = 0; j < s2.Length; j++)
            {
                if(s1[i] == s2[j])
                {
                    answer++;
                    break;
                }
            }
        }
        return answer;
    }
}