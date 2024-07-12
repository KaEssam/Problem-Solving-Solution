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
    public ListNode MiddleNode(ListNode head) {
        int count = 0;
        ListNode current = head;

        while (current != null) {
            count++;
            current = current.next;
        }

        current = head;

        for (int i = 0; i < count / 2; i++) {
            current = current.next;
        }

        return current;
    }
}