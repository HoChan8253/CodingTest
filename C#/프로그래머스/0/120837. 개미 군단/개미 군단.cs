using System;

public class Solution 
{
    public int solution(int hp) 
    {
        // 풀이 1 - 반복문 없음
        //int general = hp / 5;
        //int soldier = hp % 5 / 3;
        //int worker = hp % 5 % 3;
        //int answer = general + soldier + worker;
        //return answer;
        
        // 풀이 2 - 반복문 사용
        int answer = 0;
        while(hp > 0)
        {
            if(hp >= 5) hp -= 5;
            else if(hp >= 3) hp -= 3;
            else hp -= 1;
            answer++;
        }
        return answer;
    }
}