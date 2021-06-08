using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class QueueUsingStack
    {

        Stack<int> s1 = new Stack<int>();
        Stack<int> s2 = new Stack<int>();

        public void inqueue(int item)
        {         
            s1.Push(item);
            
        }
        public int dequeue()
        {
            int val;
            if (s1.Count == 0 && s2.Count == 0)
            {
                Console.WriteLine("no item in the queue");
                return -1;
            }
            else
            {
                if (s2.Count == 0)
                {
                    while (s1.Count > 0)
                    {
                        s2.Push(s1.Pop());
                    }
                    // val=  s2.Pop();
                }
            }
            Console.WriteLine($" item in the queue{s2.Pop()}");
            val = s2.Pop();

            return val;
        }
    }

}



//public void inqueue(int item)
//{
//    while (s1.Count > 0)
//    {
//        s2.Push(s1.Pop());
//    }
//    s1.Push(item);
//    while (s2.Count > 0)
//    {
//        s1.Push(s2.Pop());
//    }
//}
//public int dequeue()
//{
//    Console.WriteLine($"{s1.Pop()}");

//    return s1.Pop();
//}