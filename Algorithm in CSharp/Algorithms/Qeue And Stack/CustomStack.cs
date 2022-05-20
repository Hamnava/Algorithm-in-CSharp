using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_in_CSharp.Algorithms.Qeue_And_Stack
{
    public class CustomStack
    {
        public void BultInStack()
        {
            Stack<string> stack = new Stack<string>();
            Console.WriteLine("Start main ");
            stack.Push("Main");

            Console.WriteLine("Start ProccessBuilder ");
            stack.Push("ProcessBuilder");

            Console.WriteLine("Start CallExternalProcess");
            stack.Push("CallExternalProcess");

            Console.WriteLine("End " + stack.Pop());

            Console.WriteLine("Start CallEnternalProcess");
            stack.Push("CallEnternalProcess");

            Console.WriteLine("End " + stack.Pop());
            Console.WriteLine("End " + stack.Pop());
            Console.WriteLine("End " + stack.Pop());
        }
    }
}
