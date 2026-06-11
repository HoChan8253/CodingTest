using System;

public class Solution 
{
    public int solution(int[] num_list) 
    {
        // 이 문제에서 배열에 음수가 여러개일땐 어떻게 되는거지?
        int answer = -1;
        for(int i = 0; i < num_list.Length; i++)
        {
            if(0 > num_list[i])
            {
                answer = i;
                break;
            }
        }
        return answer;
    }
}