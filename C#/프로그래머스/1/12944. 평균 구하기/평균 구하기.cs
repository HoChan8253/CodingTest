using System;
//using System.Linq;

public class Solution 
{
    public double solution(int[] arr) 
    {
        // 풀이 1 - LINQ 사용
        //return arr.Average();
        
        // 풀이 2 - foreach 사용
        int result = 0;
        foreach(int sum in arr) result += sum;
        return result / (double)arr.Length;
    }
}