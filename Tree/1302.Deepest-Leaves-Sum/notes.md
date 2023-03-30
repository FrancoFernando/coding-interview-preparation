### Problem

GGiven the root of a binary tree, return the sum of values of its deepest leaves.
 

Example 1:


Input: root = [1,2,3,4,5,null,6,7,null,null,null,null,8]
Output: 15
Example 2:

Input: root = [6,7,8,2,7,1,3,9,null,1,4,null,null,null,5]
Output: 19
 

Constraints:

The number of nodes in the tree is in the range [1, 104].
1 <= Node.val <= 100

### Thinking Process

The problem can be solved both with DFS and BFS. BFS has a simpler implementation: iterate over each level and compute the sum of its nodes.
The result is given by the last computed sum.

### Complexity

* O(N) time
* O(N) spece
