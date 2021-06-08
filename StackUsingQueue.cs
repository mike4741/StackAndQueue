using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class StackUsingQueue
    {

        private Queue<int> q1 = new Queue<int>();
        private Queue<int> q2 = new Queue<int>();

        public void Push(int item)
        {
            q2.Enqueue(item);
            while (q1.Count > 0)
            {
                q2.Enqueue(q1.Dequeue());
            }

            Queue<int> temp;
            temp = q2;
            q2 = q1;
            q1 = temp;


        }
        public int Pop()
        {
            if (q2.Count == 0 && q1.Count == 0)
            {
                Console.WriteLine("the stack is empty");
                return -1;
            }
            else
            {
                int val;
                val = q1.Dequeue();
                Console.WriteLine($"the value {val}");
                return val;
            }
        }
    }

}   

