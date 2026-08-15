using System;
using System.Text;

public class Solution 
{
    public string solution(string myString) 
    {
        StringBuilder sb = new StringBuilder();
        
        foreach(char c in myString)
        {
            if(c < 'l') sb.Append('l');
            else sb.Append(c);
        }
        
        return sb.ToString();
    }
}