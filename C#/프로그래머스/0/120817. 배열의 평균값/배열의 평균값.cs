using System;
//using System.Linq;

public class Solution 
{
    public double solution(int[] numbers) 
    {
        // 풀이 1 - foreach 사용
        int result = 0;
        double answer = 0;
        foreach(int sum in numbers)
        {
            result += sum;
        }
        answer = result / (double)numbers.Length;
        return answer;
        
        // 풀이 2 - LINQ 사용
        //return numbers.Average();
    }
}