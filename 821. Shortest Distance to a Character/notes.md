# Thinking Process 

1. Need to fill each place i with the shortest distance of the corresponding char s[i] to c.
The shortest distance from s[i] to c is the min distance from the first occurrence of c on the left and on the right.
Input string s can be divided in intervals according to occurrences of c.
The first of last intervals shall be filled starting from the first (last) occurrence of c and iterating backward (onward).
The middle intervals can be filled starting from andpoints and going towards the middle.

# Complexity (approach 1)

* O(N) time
* O(1) space






