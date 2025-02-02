public class MyQueue
{
    ListNode head = null;
    ListNode tail = null;

    public void enqueue(ListNode node)
    {
        node.prev = this.tail;
        this.tail.next = node;
        this.tail = node;
    }

    public ListNode dequeue()
    {
        var temp = this.head;
        this.head.next.prev = null;
        this.head = this.head.next;
        return temp;
    }

    public ListNode peek()
    {
        return this.head;
    }
}