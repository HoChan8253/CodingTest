using System;

public class Solution 
{
    public int solution(int[] array, int n) 
    {
        int answer = array[0];
        int minDistance = Math.Abs(array[0] - n);
        
        foreach(int num in array)
        {
            int distance = Math.Abs(num - n);
            
            if(distance < minDistance)
            {
                minDistance = distance;
                answer = num;
            }
            else if(distance == minDistance && num < answer)
            {
                answer = num;
            }
        }
        return answer;
    }
}