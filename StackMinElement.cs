using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class StackMinElement
    {
       private  Stack<int> vs = new Stack<int>();
       //private Stack<int> minStack = new Stack<int>();
       private int minval;

       
        public void Push( int item )
        {
           if(vs.Count== 0)
            {
                vs.Push(item);
                minval = item;
            }
           else if (vs.Peek()>= item)
            {
                vs.Push(2 * item - minval);
                minval = item;
            }
           else
            {
                vs.Push(item);
            }
            Console.WriteLine($"at push  the min value  is  : {minval}");
        }
        public int Pop()
        {
            int result = -1;
            if(vs.Count== 0)
            {
                Console.WriteLine("no value in the stack");
            }
            else if (vs.Peek() <= minval)
            {
                minval = 2 * minval - vs.Peek();
                result = ((vs.Pop()) + minval) / 2;
             
            }
            else
            {
                result = vs.Pop();
              
            }

            Console.WriteLine($" pop value -  {result}");
            return result;
        }
         public int GetMin()
        {
            Console.WriteLine($"@min value when calling min function  {minval}");
            return minval;
        }
    }
}
