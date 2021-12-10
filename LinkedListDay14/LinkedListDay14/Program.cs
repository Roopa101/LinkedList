using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDay14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Welcome to Datastructure");
            LinkedList list = new LinkedList();
            list.Add(56);
            //list.Add(70);
            list.InsertAtParticularPosition(30, 1);
            list.Add(70);

            list.Display();

            //insert the 40 new node to the given linked list
           // list.Search(40);
            list.InsertAtParticularPosition(40, 2);

            list.Display();
           // list.DeleteNodeAtParticularPosition(3);
            //list.Display();
            Console.WriteLine("Size of linked list is : " +list.Size());
            Console.WriteLine("Sorted List");
            list.SortList();



            //list.Pop();
            // list.RemoveLastNode();
            //list.Search(30);
             list.Display();

            Console.ReadKey();
        }
    }
}
