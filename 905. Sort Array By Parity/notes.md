# Thinking Process 

The solution is based on two pointers method. Two invariants are mantained 
1. all elements on the right of right pointers are odd
2. all elements to the left of the left pointer are even
When the pointers don't keep the invariant swap the elements.


# Complexity

* O(N) time to iterate through all the numbers
* O(1) space
