class Solution:
    def reverseVowels(self, s: str) -> str:
        vowels = set('aeiouAEIOU')
        chars = list(s)  # Convert string to list of characters
        left, right = 0, len(s) - 1

        while left < right:
            while left < right and chars[left] not in vowels:
                left += 1
            
            while left < right and chars[right] not in vowels:
                right -= 1
            
            if left < right:
                chars[left], chars[right] = chars[right], chars[left]
                left += 1
                right -= 1

        return ''.join(chars)
