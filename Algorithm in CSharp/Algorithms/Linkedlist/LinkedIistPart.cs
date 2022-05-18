

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
