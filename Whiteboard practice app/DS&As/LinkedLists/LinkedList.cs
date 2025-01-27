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
}