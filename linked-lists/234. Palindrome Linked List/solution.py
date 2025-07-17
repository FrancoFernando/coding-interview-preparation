# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def isPalindrome(self, head: Optional[ListNode]) -> bool:
        
        middle = self.findMidNode(head)

        tail = self.reverse(middle)

        while head and tail:
            if head.val != tail.val:
                return False
            head = head.next
            tail = tail.next
        
        return True

    def findMidNode(self, head: Optional[ListNode]) -> ListNode:

        slow = fast = head

        while fast and fast.next:
            slow = slow.next
            fast = fast.next.next
        
        return slow
    
    def reverse(self, head: Optional[ListNode]) -> ListNode:

        prev = None
        curr = head

        while curr:
            tmp = curr.next
            curr.next = prev
            prev = curr
            curr = tmp
        
        return prev
