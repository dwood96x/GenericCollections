using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            LinkedList<string> linkedlist = new LinkedList<string>();
            Queue<int> queue = new Queue<int>();
            Stack<string> stack = new Stack<string>();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            SortedList<string, int> sortedList = new SortedList<string, int>();
            HashSet<string> hashset = new HashSet<string>();

            list.AddRange(new int[]{ 1,2,3,4,5});
            Console.WriteLine("Printing from a list.");
            foreach (var item in list)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine("\nList are very much like arrays but better in many ways. They are dynamic and you can add/remove \nvalues wherever you'd like. ");
            linkedlist.AddFirst("One");
            linkedlist.AddLast("Two");
            linkedlist.AddLast("Three");
            linkedlist.AddLast("Four");
            linkedlist.AddLast("Five");
            Console.WriteLine("\nPrinting from a linked list.");
            foreach (var item in linkedlist)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine("\nLinked list put the data into nodes. You have to go across nodes to access the data you want.");
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);
            Console.WriteLine("\nPrinting from a queue.");
            foreach (var item in queue)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine("\nQueues are setup the way a line at a store is. The first one in is the first one out.");
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");
            stack.Push("Last");
            Console.WriteLine("\nPrinting from a stack.");
            foreach (var item in stack)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine("\nStacks are like a stack of trays. To get to the tray in the middle you have to pop off the ones ontop. \nFirst one on is last one out.");
            dictionary["One"] = 1;
            dictionary["Two"] = 2;
            dictionary["Three"] = 3;
            dictionary["Four"] = 4;
            dictionary["Five"] = 5;
            Console.WriteLine("\nPrinting from a dictionary.");
            foreach (var item in dictionary)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine("\nDictionarys utilize a key and value system. Every value has a key and you get the value only by \nproviding the key.");
            sortedList.Add("One",1);
            sortedList.Add("Two", 2);
            sortedList.Add("Three", 3);
            sortedList.Add("Four", 4);
            sortedList.Add("Five", 5);
            Console.WriteLine("\nPrinting from a sorted list.");
            foreach (var item in sortedList)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine("\nSorted list are sorted in ascending order by default. Whenver you add/remove it gets sorted again.");
            hashset.Add("Apple");
            hashset.Add("Banana");
            hashset.Add("Cat");
            hashset.Add("Dog");
            hashset.Add("Elephant");
            Console.WriteLine("\nPrinting from a hashset.");
            foreach (var item in hashset)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine("\nHashsets are sets which mean they have no order. They also don't take duplicates. On the \nother hand they can provide performance boost compared to other data structures");
        }
    }
}
