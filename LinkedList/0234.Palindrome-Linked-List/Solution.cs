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

// recursive solution
public class Solution {

    public bool IsPalindromeHelper(ListNode currentNode, ref ListNode oppositeNode) {

        if (currentNode == null) return true; //base case
        if (!IsPalindromeHelper(currentNode.next, ref oppositeNode) || currentNode.val != oppositeNode.val) return false; //bubble failure up
        oppositeNode = oppositeNode.next;
        return true;
    }

    public bool IsPalindrome(ListNode head) {
        ListNode oppositeNode = head;
        return IsPalindromeHelper(head, ref oppositeNode);
    }
}
