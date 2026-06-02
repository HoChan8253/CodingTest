using System;
using System.Linq;
using System.Text.RegularExpressions;
public class Solution 
{
    public string solution(string my_string) 
    {
        // 풀이 1 - foreach, if
        //string answer = "";
        //foreach(char c in my_string)
        //{
        //    if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
        //   {
        //        continue;
        //   }
        //    answer += c;
        //}
        //return answer;
        
        // 풀이 2 - Replace
        //public string solution(string my_string) 
        //{
        //    foreach(char c in "aeiou")
        //        my_string = my_string.Replace(c.ToString(), "");
        //    return my_string;
        //}
        
        // 풀이 3 - Contains
        //string answer = "";
        //string vowels = "aeiou";
        //foreach(char c in my_string)
        //{
        //    if(!vowels.Contains(c))
        //    answer += c;
        //}
        //return answer;
        
        // 풀이 4 - LINQ
        return new string(my_string.Where(c => !"aeiou".Contains(c)).ToArray());
        
        // 풀이 5 - Regex
        // return Regex.Replace(my_string, "[aeiou]", "");
    }
}