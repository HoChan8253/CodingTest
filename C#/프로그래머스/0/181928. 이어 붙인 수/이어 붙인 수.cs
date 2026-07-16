using System;

public class Solution 
{
    public int solution(int[] num_list) 
    {
        string odd = "";
        string even = "";
        
        foreach(int num in num_list)
        {
            if(num % 2 == 0)
                even += num.ToString();
            else
                odd += num.ToString();
        }
        
        int oddNum = int.Parse(odd);
        int evenNum = int.Parse(even);
        
        return oddNum + evenNum;
    }
}