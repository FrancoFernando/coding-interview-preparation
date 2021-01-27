# Thinking Process

1. Solve brute force following the definition but using bit manipulation. The n-th number can
be computed as b(n) = b(n-1)n where b(n) is the binary representation of n. The concatenation
can be performed  shifting b(n-1) to the left and making a bitwise or with n. The number of position of the shift depend on the size of b(n).

# Complexity

* O(N) time
* O(1) space


