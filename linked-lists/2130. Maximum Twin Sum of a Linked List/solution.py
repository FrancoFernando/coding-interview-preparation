# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def pairSum(self, head: Optional[ListNode]) -> int:

        prev = None
        slow = fast = head

        while fast and fast.next:
            prev = slow
            slow = slow.next
            fast = fast.next.next

        # prev point to the second half of the list
        curr = prev.next
        prev = None    
        
        
        while curr:
            tmp = curr.next
            curr.next = prev
            prev = curr
            curr = tmp

        #prev is the head of the reversend second half
        result = 0
        while prev:
            result = max(result, prev.val+head.val)
            prev = prev.next
            head = head.next
        return result
            

        

        
        
