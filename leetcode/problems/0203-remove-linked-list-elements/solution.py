"""
LeetCode #203: Remove Linked List Elements
Difficulty: Easy
Link: https://leetcode.com/problems/remove-linked-list-elements/
"""
from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


# Recursive
class SolutionRecursive:
    def removeElements(self, head: Optional[ListNode], val: int) -> Optional[ListNode]:
        if head is None:
            return None

        if head.val == val:
            return self.removeElements(head.next, val)

        head.next = self.removeElements(head.next, val)
        return head


# Iterative
class Solution:
    def removeElements(self, head: Optional[ListNode], val: int) -> Optional[ListNode]:
        dummy = ListNode(0, head)
        current = dummy

        while current.next is not None:
            if current.next.val == val:
                current.next = current.next.next
            else:
                current = current.next

        return dummy.next
