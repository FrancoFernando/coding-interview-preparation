# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:

        dummy = ListNode(0,head)
        fast = head
        slow = dummy

        while fast is not None:
            fast = fast.next
            if n == 0:
                slow = slow.next
            else:
                n -= 1

        slow.next = slow.next.next

        return dummy.next
