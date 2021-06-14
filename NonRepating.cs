using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class NonRepatingChar
    {
        readonly static int Max_Char = 254;  
        List<char> inDLL = new List<char>();
        bool[] repeated = new bool[Max_Char];
        char Rchar;
        public  void findNonRepating( string stream)
        {
          
            for (int i = 0; i < stream.Length; i++)
            {
                Rchar = stream[i];
                if (!repeated[Rchar])
                {
                    if (!(inDLL.Contains(Rchar)))
                    {
                        inDLL.Add(Rchar);
                    }
                    else 
                    {
                        inDLL.Remove((char)Rchar);
                        repeated[Rchar] = true; 
                    }
                }
               
                if (inDLL.Count != 0)
                {
                    Console.Write($"First non-repeating character so far is {inDLL[0]}\n" );
                }

            }
        }
    }
}