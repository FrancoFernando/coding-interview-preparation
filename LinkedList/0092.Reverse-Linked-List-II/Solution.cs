/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    
    public ListNode ReverseAndConnectTail(ListNode head, int nodesToReverse) {
        
        var tail = head; // save the tail to attach
        
        //normal reverse list algorithm
        ListNode prevNode = null;
        for (int i = 0; i < nodesToReverse; ++i) {
            var nextNode = head.next;
            head.next = prevNode;
            prevNode = head;
            head = nextNode;
        }
        
        tail.next = head; //attach the tail
        
        return prevNode;
    }
     
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        
        ListNode dummyHead = new ListNode(0, head);
        ListNode preHead = dummyHead;
        
        for (int i = 1; i < left; ++i) preHead = preHead.next;
        
        preHead.next = ReverseAndConnectTail(preHead.next, right-left+1);
        
        return dummyHead.next;

    }
}
