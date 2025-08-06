# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def oddEvenList(self, head: Optional[ListNode]) -> Optional[ListNode]:

        odd = curr_odd = head
        even = curr_even = head.next

        while odd and even:
            curr_odd.next = even.next
            curr_even.next = head.next
            head = head.next.next
            curr_odd = curr_odd.next
            curr_even = curr_even.next

        if head:
            curr_odd.next = head
            curr_odd = curr_odd.next

        curr_even.next = None
        curr_odd.next = even.next   
         
        return odd.next
        
            
            
        
