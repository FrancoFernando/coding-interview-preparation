### Description

Given the root of a binary tree, return the length of the diameter of the tree.

The diameter of a binary tree is the length of the longest path between any two nodes in a tree. This path may or may not pass through the root.

The length of a path between two nodes is represented by the number of edges between them.

 

Example 1:


Input: root = [1,2,3,4,5]
Output: 3
Explanation: 3 is the length of the path [4,2,1,3] or [5,2,1,3].
Example 2:

Input: root = [1,2]
Output: 1
 

Constraints:

The number of nodes in the tree is in the range [1, 104].
-100 <= Node.val <= 100

### Thinking process

The maximum diameter for a node is the sum of the maximum depth of its left and right subtree.
The problem can then be solved using dfs and recursively measuring the depth of subtrees..
If the maximum diameter of the current node is the maximum seen so far, the maximum diameter of the tree is updated

### Complexity

* Time complexity is O(N) to traverse all nodes
* Space complexity is O(N) for the recursion stack
