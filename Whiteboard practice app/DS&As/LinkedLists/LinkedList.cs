public class LinkedList
{
    /*
        Given the head of a singly linked list, return the middle node of the linked list.

        If there are two middle nodes, return the second middle node.

        

        Example 1:


        Input: head = [1,2,3,4,5]
        Output: [3,4,5]
        Explanation: The middle node of the list is node 3.
        Example 2:


        Input: head = [1,2,3,4,5,6]
        Output: [4,5,6]
        Explanation: Since the list has two middle nodes with values 3 and 4, we return the second one.
    */
    public ListNode GetMiddleListNode(ListNode head)
    {
        int count = 1;
        var curr = head;
        while(curr.next != null)
        {
            curr = curr.next;
            count++;
        }

        curr = head;
        int mid = count / 2;
        while(mid > 0)
        {
            curr = curr.next;
            mid--;
        }

        return curr;
    }

    /*
        Given the head of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list sorted as well.

        Example 1:


        Input: head = [1,1,2]
        Output: [1,2]
        Example 2:


        Input: head = [1,1,2,3,3]
        Output: [1,2,3]
    */
    public ListNode DeleteDuplicates(ListNode head)
    {
        if(head == null || head.next == null) return head;

        var prev = head;
        var curr = head.next;

        while(curr != null)
        {
            if(prev.val == curr.val) 
            {
                curr = curr.next;
                prev.next = curr;
            }
            else
            {
                prev = curr;
                curr = curr.next;
            }
        }

        return head;
    }

    /*
        Given the head of a singly linked list, 
        reverse the nodes of the list
    */

    public ListNode? ReverseLinkedList(ListNode head)
    {
        ListNode? prev = null;
        ListNode? curr = head;

        while(curr != null)
        {
            var next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }

    /*
        Given the head of a singly linked list and two integers left and right where left <= right, 
        reverse the nodes of the list from position left to position right, and return the reversed list.

        Example 1:
        Input: head = [1,2,3,4,5], left = 2, right = 4
        Output: [1,4,3,2,5]

        Example 2:
        Input: head = [5], left = 1, right = 1
        Output: [5]
        
    */

    public ListNode ReverseLinkedListII(ListNode head, int left, int right)
    {
        if(left == right) return head;

        int index = 1;
        ListNode prev = null;
        ListNode curr = head;
        while(index < left)
        {
            prev = curr;
            curr = curr.next;
            index++;
        }

        ListNode prev2 = null;
        ListNode curr2 = curr;
        while(index < right)
        {
            var next = curr2.next;
            curr2.next = prev2;
            prev2 = curr2;
            curr2 = next;
            index++;
        }
        curr.next = curr2.next;
        if(prev != null) prev.next = curr2;
        else head = curr2;
        curr2.next = prev2;

        return head;
    }
}