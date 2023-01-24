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

// Recursive solution
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

// Optimized solution
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

    public ListNode FindMiddleNode(ListNode head) {

        ListNode slow = head, fast = head;

        while(fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }

    public ListNode ReverseList(ListNode head) {

        ListNode prev = null;
        while(head != null) {
            var next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }

        return prev;
    }

    bool isPalindrome(ListNode head, ListNode tail) {

        while (head != null && tail != null) {
            if (head.val != tail.val) return false;
            head = head.next;
            tail = tail.next;
        }
        return true;
    }

    public bool IsPalindrome(ListNode head) {

        var middleNode = FindMiddleNode(head);
        var tailNode = ReverseList(middleNode);
        return isPalindrome(head, tailNode);
    }
}
