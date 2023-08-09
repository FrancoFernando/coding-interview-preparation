# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
from typing import Optional

class Solution:

    def deleteNode(self, root: Optional[TreeNode], key: int) -> Optional[TreeNode]:

        if root is None:
            return None

        if root.val == key:
            # key has no children
            if root.left is None and root.right is None:
                return None

            # key has one child
            if root.left is None:
                return root.right

            if root.right is None:
                return root.left

            # key has two children
            successor = self.findSuccessor(root.right)
            root.val, successor.val = successor.val, root.val
            root.right = self.deleteNode(root.right, key)

        elif root.val > key:
            root.left = self.deleteNode(root.left, key)
        elif root.val < key: 
            root.right = self.deleteNode(root.right, key)
            
        return root

        def findSuccessor(self, root: Optional[TreeNode]) -> Optional[TreeNode]:

            while root.left is not None:
                root = root.left

            return root

        

        
