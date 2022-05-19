

namespace Algorithm_in_CSharp.Algorithms.Linkedlist
{
    public class CustomLinkedList
    {
       public Node head;

        public class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
            }
        }

        public void DeleteKthNodeFromEnd(int k)
        {
            if (head == null || k == 0) return;
            // [a,b,c,d]
            // k = 2
            Node first = head;
            Node second = head;

            for (int i = 0; i < k; i++)
            {
                second = second.next;
                if (second.next == null)
                {
                    // k >= length of list
                    if(i == k - 1)
                    {
                        head = head.next;
                    }
                    return;
                }

            }

           // second = c

            while (second != null)
            {
                first = first.next;
                second = second.next;
            }
            // first = b
            // second = d

            first.next = first.next.next;
        }
        public void DeleteBackHalf()
        {
            if(head == null || head.next == null) head = null;
            Node slow = head;
            Node fast = head;
            Node prev = null;

            while(fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }
            prev.next = null;
        }
        public void DisplayNods()
        {
            var current = head;
            while (current != null)
            {
                Console.Write(current.data + " -> ");
                current = current.next;
            }
        }
    }
    public class LinkedIistPart
    {
        

        public void strLinkedList()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("Ahmad");
            list.AddLast("Reza");
            list.AddLast("Laila");
            list.AddLast("Latifa");
            list.AddLast("Hamnava");

            Console.WriteLine(list.Count());

            list.RemoveFirst();
            foreach (var item in list)
            {
                Console.Write(item + " ----------> ");
            }
            Console.WriteLine();
        }

    }
}
