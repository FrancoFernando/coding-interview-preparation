### Problem

Given the root of a binary tree, return its maximum depth.

A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.

 

Example 1:


Input: root = [3,9,20,null,null,15,7]
Output: 3
Example 2:

Input: root = [1,null,2]
Output: 2
 

Constraints:

The number of nodes in the tree is in the range [0, 104].
-100 <= Node.val <= 100

### Thinking Process

The best way to solve this problem, we can use a recursive approach. 
We start at the root node and recursively calculate the maximum depth of the left and right subtrees. 
We then take the maximum of these two values and add 1 to account for the current node.

### Complexity

* O(N) time
* O(N) space
