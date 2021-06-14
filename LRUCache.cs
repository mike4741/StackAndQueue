using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
   public class LRUCache
    {

        private Node head = new Node();
        private Node tail = new Node();
        private Dictionary<int , Node> node_map;
        private int Cache_Capacity;

        public LRUCache(int capacity)
        {
            node_map = new Dictionary<int , Node>(capacity);
            Cache_Capacity = capacity;
            head.next = tail;
            tail.prev = head;
        }

        public int Get(int Key)
        { 
            int result = -1;
            if (node_map.ContainsKey(Key))
            {
                Node node = node_map[Key];
                result = node.val;
                Remove(node);
                add(node);

            }


            Console.WriteLine($" the return values =  {result}");
            return result;
        }

        public void set (int key , int value){
           if (node_map.ContainsKey(key))
            {
                Node node = node_map[key];
                Remove(node);
                node.val = value;
                add(node);

            }
           else 
            {
                if(node_map.Count== Cache_Capacity)
                {
                    node_map.Remove(tail.prev.key);
                    Console.WriteLine($"remove from the list : {tail.prev}");
                    Remove(tail.prev);
                }
                Node node = new Node();
                node.key = key;
                node.val = value;
                add(node);
                node_map[key] = node;
               
            }
          
            }
        public void add(Node node)
        {
            node.next = head.next;
            node.prev = head;
            head.next.prev = node;
            head.next = node;

        }
        public void  Remove(Node node)
        {
            node.next.prev = node.prev;
            node.prev.next = node.next;

        }

    public class Node
        {
          public int key;
          public int val;
          public Node prev;
          public Node next;
        }

    }
}
