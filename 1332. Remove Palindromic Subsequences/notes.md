# Thinking Process

1. It is just to understand the trick. Since there are only two symbols and you can remove palindrome subssequences (not subarrays)
   there are only two cases. The string is already palindrome and becomes empty with one remove. Otherwise the string is not palindrome and becomes empty with two removes: in the first remove te subsequence with all 'a' and in the second the subsequence with all 'b'. Corner case is the already empty string that requires 0 removes.

# Complexity

* O(N) time to check f the string is palindrome.
* O(1) space 


