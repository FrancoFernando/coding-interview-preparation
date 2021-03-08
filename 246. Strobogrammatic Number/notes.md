# Thinking Process 

1. It is not difficult but it is necessary to understand all cases. Use two pointers to match first and last char of the string and check if they are the same after the rotation. They are if both 0,1,8 or if are pairs 6,9 or 9,6. In all other cases are not. Corner case the middle char in case of odd strings. This must be 1,0 or 8.

# Complexity (approach 1)

* O(N) time
* O(1) space for the hash tables storing the correspondences between a number and is rotated counterpart.






