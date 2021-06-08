using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");
            // NextGreterElement nextGreter = new NextGreterElement();
            // int[] a = new int[] { 13,7,6,12 };
            // nextGreter.PrintNGE(a);


            // QueueUsingStack queue = new QueueUsingStack();
            //queue.inqueue(11);
            //queue.inqueue(12);
            //queue.inqueue(13);
            //queue.inqueue(14);
            // queue.dequeue();


            //StackUsingQueue stack = new StackUsingQueue();
            //stack.Push(11);
            //stack.Push(13);
            //stack.Push(14);
            //stack.Pop();


            StackMinElement stackMin = new StackMinElement();
            stackMin.Push(14);
            stackMin.Push(12);
            stackMin.Push(16);
            stackMin.GetMin();
            stackMin.Push(7);
            stackMin.Push(8);
            stackMin.Push(5);
            stackMin.GetMin();
            stackMin.Pop();
            stackMin.GetMin();
            stackMin.Pop();






        }
    }
}
