"""
LeetCode #2074: Reverse Nodes in Even Length Groups
Difficulty: Medium
Link: https://leetcode.com/problems/reverse-nodes-in-even-length-groups/
"""
from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


class Solution:
    def reverseEvenLengthGroups(self, head: Optional[ListNode]) -> Optional[ListNode]:
        curr = ListNode(0, head)
        remaining_length = self.getLength(head)
        group = 1

        while curr:
            length = min(remaining_length, group)

            if length % 2 != 0:
                curr = self.skipGroup(curr, length)
            else:
                tmp = curr.next  # future tail
                curr.next = self.reverseGroup(curr.next, length)
                curr = tmp

            remaining_length -= length
            group += 1

        return head

    def getLength(self, head: Optional[ListNode]) -> int:
        length = 0
        while head:
            head = head.next
            length += 1
        return length

    def skipGroup(self, head: Optional[ListNode], nodesToSkip: int) -> Optional[ListNode]:
        for _ in range(nodesToSkip):
            head = head.next
        return head

    def reverseGroup(self, head: Optional[ListNode], nodesToReverse: int) -> Optional[ListNode]:
        if not head:
            return head

        prev = None
        curr = head

        for _ in range(nodesToReverse):
            tmp = curr.next
            curr.next = prev
            prev = curr
            curr = tmp

        head.next = curr  # connect the old head/new tail to next node
        return prev
