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

        public void PrintNextGreaterElement(int[] arr)
        {
            if (arr.Length <= 0)
            {
                Console.WriteLine();
                return;
            }

            Stack<int> stack = new Stack<int>();
            stack.Push(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                int next = arr[i];
                if (stack.Count > 0)
                {
                    int popped = stack.Pop();
                    while (popped < next)
                    {
                        Console.WriteLine(popped + " --> " + next);
                        if (stack.Count == 0)
                        {
                            break;
                        }
                        popped = stack.Pop();
                    }

                    if (popped > next)
                    {
                        stack.Push(popped);
                    }
                }
                stack.Push(next);
            }

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop() + "--> " + "-1");
            }
        }

        public string Solution(string angles)
        {
            // Type your solution here

            int openCount = 0;
            int additionalLeadingOpenTags = 0;

            foreach (char c in angles)
            {
                if (c == '>')
                {
                    if (openCount == 0)
                    {
                        additionalLeadingOpenTags++;
                    }
                    else
                    {
                        openCount--;
                    }
                }
                else
                {
                    openCount++;
                }
            }

            StringBuilder result = new StringBuilder();
            while (additionalLeadingOpenTags > 0)
            {
                result.Append("<");
                additionalLeadingOpenTags--;
            }
            result.Append(angles);
            while (openCount > 0)
            {
                result.Append(">");
                openCount--;
            }
            Console.WriteLine(result.ToString());
            return result.ToString();
        }
    }
}
