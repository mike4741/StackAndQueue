using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class NextGreterElement
    {
        

        public void PrintNGE(int[]a)
        {
            Stack<int> s = new Stack<int>();
            int[] nge = new int[a.Length];

            s.Push(a[a.Length-1]);
            nge[a.Length - 1] = -1;


            for (int i = a.Length - 2; i >= 0; i--)
            {

                while (s.Count>0 && a[i] >= s.Peek())
                {
                    s.Pop();
                }

                if (s.Count == 0)
                {
                    nge[i] = -1;
                }
                else
                {
                    nge[i] = s.Peek();
                }
                s.Push(a[i]);

            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + "-->" + nge[i]);
            }
        
        }

    }
}
