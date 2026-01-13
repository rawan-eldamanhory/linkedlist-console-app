using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //create linkedlist
            LinkedList<int> list = new LinkedList<int>();

            //add elements in linkedlist
            list.AddFirst(5);    //add at the first 
            list.AddFirst(2);
            list.AddFirst(8);
            list.AddLast(4);     //add at the last
            list.AddLast(9);
            list.AddLast(1);

            //display content
            Console.WriteLine("Content of linkedlist : ");
            foreach (int item in list)
                Console.WriteLine(item);       // 8 2 5 4 9 1 

            //remove elements from linkedlist
            list.Remove(4);      //remove item (4)
            list.RemoveFirst();  //remove item (8)
            list.RemoveLast();   //remove item (1)

            Console.WriteLine("Content of linkedlist after deletion : ");
            foreach (int item in list)
                Console.WriteLine(item);         // 2 5 9

            //finding an element in linkedlist
            Console.WriteLine("The value 2 is present in Linked List : " + list.Contains(2));  //True
            Console.WriteLine("The value 6 is present in Linked List : " + list.Contains(6));  //False

            //add a node after a given node in linkedlist
            var n = list.AddFirst(3);
            list.AddAfter(n, 10);
            //add a node before a given node in linkedlist
            list.AddBefore(n, 20);

            Console.WriteLine("Content of linkedlist after insertion : ");
            foreach (int item in list)
                Console.WriteLine(item);   // 20 3 10 2 5 9

            //check whether a node is in the linkedlist
            Console.WriteLine("Is item 10 in the linkedlist ? : " + list.Contains(10));   //True
            Console.WriteLine("Is item 4 in the linkedlist ? : " + list.Contains(4));     //False

            //clear all the elements
            //list.Clear();

            Console.ReadKey();
        }
    }
}
