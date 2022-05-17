using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_in_CSharp.Algorithms.Linkedlist
{
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
                Console.WriteLine(item + "---------->");
            }
        }

    }
}
