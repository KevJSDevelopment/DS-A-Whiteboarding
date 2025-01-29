public class MyStack
{
    private ListNode head = null;
    private ListNode tail = null;

    public void Append(ListNode node)
    {
        if(head == null)
        {
            head = node;
            tail = head;
        }

        tail.next = node;
        node.prev = tail;
        tail = node;
    }

    public ListNode Pop()
    {
        ListNode temp = tail;
        tail.prev.next = null;
        tail = tail.prev;
        return temp;
    }

    public int Peek()
    {
        return tail.val;
    }
}