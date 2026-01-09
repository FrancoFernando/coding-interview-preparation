"""
LeetCode #1721: Swapping Nodes in a Linked List
Difficulty: Medium
Link: https://leetcode.com/problems/swapping-nodes-in-a-linked-list/
"""
from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


class Solution:
    def swapNodes(self, head: Optional[ListNode], k: int) -> Optional[ListNode]:
        first = second = end = head

        for _ in range(k - 1):
            first = first.next

        # second and first are k-1 nodes apart
        end = first
        while end.next:
            end = end.next
            second = second.next

        first.val, second.val = second.val, first.val

        return head
