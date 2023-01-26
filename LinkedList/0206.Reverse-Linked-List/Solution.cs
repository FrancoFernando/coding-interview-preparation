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
    public ListNode ReverseList(ListNode head) {
        
        ListNode prevNode = null, currentNode = head;

        while (currentNode != null) {
            var nextNode = currentNode.next;
            currentNode.next = prevNode;
            prevNode = currentNode;
            currentNode = nextNode;
        }
        return prevNode;
    }
}

//naive recirsive solution
//need to manually set head and tail
public class Solution {

    ListNode tail = null;

    public ListNode ReverseList(ListNode head) {
        if (ReverseListH(head) == null) return null;
        head.next = null;
        return tail;
    }

    public ListNode ReverseListH(ListNode head) {
        
        if (head == null) return null;
        var prevNode = ReverseListH(head.next);
        if (prevNode != null) prevNode.next = head;
        else tail = head;
        return head;
    }
}
