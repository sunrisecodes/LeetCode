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
           public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if(list1 == null) return list2;
            if(list2 == null) return list1;

            ListNode p1 = list1;
            ListNode p2 = list2;
            ListNode current;
            ListNode sortedNode;
            if (list1.val <  list2.val)
            {
                current = list1;
                sortedNode = current;
                p1 = p1.next;
            }
            else
            {
                current = list2;
                sortedNode = current;
                p2 = p2.next;
            }
            while (p1 != null && p2 != null)
            {
                if (p1.val < p2.val)
                {
                    current.next = p1;
                    p1 = p1.next;
                }
                else if (p2.val < p1.val)
                {
                    current.next = p2;
                    p2 = p2.next;
                }
                else 
                {
                    current.next = p1;
                    current = current.next;
                    p1 = p1.next;

                    current.next = p2;
                    p2 = p2.next;
                }
                current = current.next;

            }
             if (p1 != null) current.next = p1;
             if (p2 != null) current.next = p2;

            return sortedNode;
        }

}