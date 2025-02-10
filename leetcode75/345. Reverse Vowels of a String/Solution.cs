public class Solution {
    private static readonly HashSet<char> Vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

    public string ReverseVowels(string s) {
        return string.Create(s.Length, s, (span, original) => { 
            int left = 0, right = s.Length - 1;

            while (left < right) {
                while (left < right && !Vowels.Contains(original[left])) {
                    span[left] = original[left];
                    left++;
                }

                while (left < right && !Vowels.Contains(original[right])) {
                    span[right] = original[right];
                    right--;
                }

                if (left < right) {
                    span[left] = original[right];
                    span[right] = original[left];
                    left++;
                    right--;
                }
            }

            // Copy any remaining characters
            while (left <= right) {
                span[left] = original[left];
                left++;
            }
        });
    }
}
