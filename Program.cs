using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            NextGreterElement nextGreter = new NextGreterElement();
            int[] a = new int[] { 13, 7, 6, 12 };
            nextGreter.PrintNGE(a);


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


            //StackMinElement stackMin = new StackMinElement();
            //stackMin.Push(14);
            //stackMin.Push(12);
            //stackMin.Push(16);
            //stackMin.GetMin();
            //stackMin.Push(7);
            //stackMin.Push(8);
            //stackMin.Push(5);
            //stackMin.GetMin();
            //stackMin.Pop();
            //stackMin.GetMin();
            //stackMin.Pop();


            //LRUCache lRU = new LRUCache(3);
            //lRU.set(1, 1);
            //lRU.set(2, 2);
            //lRU.Get(1);
            //lRU.set(3, 3);
            //lRU.Get(2);
            //lRU.set(4, 4);
            //lRU.Get(1);
            //lRU.Get(3);
            //lRU.Get(4);



            //NonRepatingChar r = new NonRepatingChar();
           
            
            //r.findNonRepating("asdaadse");


        }
    }
}
