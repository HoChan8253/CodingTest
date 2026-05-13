public class Solution 
{
    public string solution(string phone_number) 
    {
        // 풀이 1 - Array 와 for문 사용
        //char[] c = phone_number.ToCharArray();
        //
        //for(int i = 0; i < c.Length - 4; i++)
        //{
        //    c[i] = '*';
        //}
        //return new string(c);
        
        // 풀이 2 - SubString 사용
        return new string('*', phone_number.Length - 4) + phone_number.Substring(phone_number.Length - 4);
        
        // 풀이 3 - Padding 사용
        //return phone_number.Substring(phone_number.Length - 4).PadLeft(phone_number.Length, '*');
    }
}