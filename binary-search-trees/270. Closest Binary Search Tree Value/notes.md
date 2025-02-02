# Description 

Given the root of a binary search tree and a target value, return the value in the BST that is closest to the target. If there are multiple answers, print the smallest.

Example 1:


Input: root = [4,2,5,1,3], target = 3.714286
Output: 4
Example 2:

Input: root = [1], target = 4.428571
Output: 1
 

Constraints:

The number of nodes in the tree is in the range [1, 104].
0 <= Node.val <= 109
-109 <= target <= 109

# Thought Process

Use the BST property to efficiently navigate the tree and find the closest value. 
When you meet a number as close to the the target as the current closest, pick the smallest.

# Complexity

O(logN) time for a balanced BST or O(h) otherwise, O(1) space
