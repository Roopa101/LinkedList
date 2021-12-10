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

            list.Add(30);


            //insert the 40 new node to the given linked list
            list.InsertAtParticularPosition(40, 3);
            list.Add(70);



            //list.Pop();
            // list.RemoveLastNode();
            //list.Search(30);
            list.Display();

            Console.ReadKey();
        }
    }
}
