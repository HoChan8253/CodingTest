public class Solution 
{
    public string solution(string s) 
    {
        string answer = "";
        int mid = s.Length / 2;
        if(s.Length % 2 == 0)
        {
            answer = s[mid - 1].ToString() + s[mid].ToString();
        }
        else
        {
            answer = s[mid].ToString();
        }
        return answer;
    }
}