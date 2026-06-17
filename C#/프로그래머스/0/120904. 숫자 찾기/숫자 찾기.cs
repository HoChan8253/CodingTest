using System;

public class Solution 
{
    public int solution(int num, int k) 
    {
        int answer = -1;
        string findIndex = num.ToString();
        char target = k.ToString()[0];
        for(int i = 0; i < findIndex.Length; i++)
        {
            if(findIndex[i] == target)
            {
                answer = i + 1;
                break;
            }
        }
        return answer;
    }
}