using System;

public class Solution 
{
    public int[] solution(int[] arr, int n) 
    {
        bool isOdd = arr.Length % 2 == 1;
        
        for(int i = 0; i < arr.Length; i++)
        {
            if(isOdd && i % 2 == 0) arr[i] += n;
            else if(!isOdd && i % 2 == 1) arr[i] += n;
        }
        
        return arr;
    }
}