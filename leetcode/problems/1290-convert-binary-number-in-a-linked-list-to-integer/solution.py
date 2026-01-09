"""
LeetCode #1290: Convert Binary Number in a Linked List to Integer
Difficulty: Easy
Link: https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
"""
from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


class Solution:
    def getDecimalValue(self, head: Optional[ListNode]) -> int:
        val = 0

        while head:
            val <<= 1
            val |= head.val
            head = head.next

        return val
