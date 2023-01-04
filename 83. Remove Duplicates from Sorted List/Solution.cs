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
    public ListNode DeleteDuplicates(ListNode head) {
        
        ListNode fast = head, slow = head;
            
        while (fast != null){
            
            if (fast.val != slow.val) {
                slow.next = fast;
                slow = fast;
            }
            
            fast = fast.next;
        }
        
        if (slow != null) slow.next = null;
        
        return head;
    }
}
