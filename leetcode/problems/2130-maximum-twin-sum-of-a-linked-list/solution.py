"""
LeetCode #2130: Maximum Twin Sum of a Linked List
Difficulty: Medium
Link: https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/
"""
from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


class Solution:
    def pairSum(self, head: Optional[ListNode]) -> int:
        prev = None
        slow = fast = head

        while fast and fast.next:
            prev = slow
            slow = slow.next
            fast = fast.next.next

        # prev points to the node before second half
        curr = prev.next
        prev = None

        # Reverse second half
        while curr:
            tmp = curr.next
            curr.next = prev
            prev = curr
            curr = tmp

        # prev is the head of the reversed second half
        result = 0
        while prev:
            result = max(result, prev.val + head.val)
            prev = prev.next
            head = head.next
        return result
