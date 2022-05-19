using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_in_CSharp.Algorithms.Qeue_And_Stack
{
    public class CustomeQeue
    {
        public void Classmates()
        {
        Queue<string> names = new Queue<string>();
            names.Enqueue("Hamnava");
            names.Enqueue("Latifa");
            names.Enqueue("Arash");
            names.Enqueue("Ali");
            names.Enqueue("Rahila");

            Console.WriteLine(names.Dequeue());
            Console.WriteLine(names.Peek());

            var current = "";
            while(names.TryDequeue(out current))
            {
                Console.WriteLine(current);
            }
        }
        
        
    }
}
