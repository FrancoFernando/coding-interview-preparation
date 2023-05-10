## Description

Given a positive integer n, generate an n x n matrix filled with elements from 1 to n2 in spiral order.

Example 1:

Input: n = 3
Output: [[1,2,3],[8,9,4],[7,6,5]]
Example 2:

Input: n = 1
Output: [[1]]
 
Constraints:

1 <= n <= 20

Constraints:

m == matrix.length
n == matrix[i].length
1 <= m, n <= 10
-100 <= matrix[i][j] <= 100

## Thinking process

This a simulation problem like Spiral Matrix I. In some way it's easier because there is a clear bound on the number of iterations: either the number of squares or the max value to write.
The key to solve the problem is again using and keeping updates the boundaries while traversing the matrix.

## Complexity

* O(NN) time
* O(1) space
