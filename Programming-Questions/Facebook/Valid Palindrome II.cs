public class Solution {
    public bool ValidPalindrome(string s) {
        int l = -1;
        int r = s.Length;
        while(++l < --r)
        {
            if(s[l] != s[r])
                return (IsPalindrome(s, ++l, r) || IsPalindrome(s, --l, --r));
        }
        
        return true;
    }
    
    public bool IsPalindrome(string s, int l , int r){
              Console.WriteLine($"{s[l]} {s[r]}");
        while(l < r)
        {
  
            if(s[l] != s[r])
                return false;
           l++;
           r--;
        }
        Console.WriteLine("HI");
        return true;
    }
}
