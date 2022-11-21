# Thinking Process 

Interesting problem with multiple solution.

1. Brute Force: sort the input and go through it find the first missing number.
2. Hash set: put the input into a hash set and find the missing number in the hash set
3. Bit manipulation: a number xor itself is always 0. So if we xor all the numbers with their index either we get the missing number or this number is the input's length.
4. Similar to 645 (Set mismatch). The missing number can be solved using the difference between the sum without missing number and the one with missing number. 

# Complexity 

1. O(NlogN) time, O(1) space
2. O(N) time, O(N) space 
3. O(N) time, O(1) space 
4. O(N) time, O(1) space 






