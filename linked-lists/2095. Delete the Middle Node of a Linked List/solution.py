# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
# Two-pass
class Solution:
    def deleteMiddle(self, head: Optional[ListNode]) -> Optional[ListNode]:

        list_length = 0
        current = head
        
        while current is not None:
            current = current.next 
            list_length += 1

        node_to_delete = list_length // 2
        dummy = ListNode(0,head)
        current = dummy
        
        for _ in range(node_to_delete):
            current = current.next

        current.next = current.next.next

        return dummy.next

# One-pass

# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def deleteMiddle(self, head: Optional[ListNode]) -> Optional[ListNode]:

        if head.next is None:
            return None

        slow = fast = head
        prev = None

        while fast is not None and fast.next is not None:
            prev = slow
            slow = slow.next
            fast = fast.next.next

        prev.next = slow.next

        return head
            
        
