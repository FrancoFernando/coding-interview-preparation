public class Solution {

    public string ReverseVowels(string s) {

        bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) >= 0;
        
        string answer = string.Create(s.Length, s, (a, s) => { 
            int i = 0, j = s.Length-1;
            while(i <= j) {
                if(!IsVowel(s[i])) {a[i] = s[i]; i++;}
                if(!IsVowel(s[j])) {a[j] = s[j]; j--;}
                if(i <= j && IsVowel(s[i]) && IsVowel(s[j])) {
                    (a[j],a[i]) = (s[i],s[j]);
                    i++;
                    j--;
                }
            }
        });
        return answer;
    }
}
