# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def getDecimalValue(self, head: Optional[ListNode]) -> int:

        val = 0

        while head:
            val <<= 1
            val |= head.val
            head = head.next

        return val
