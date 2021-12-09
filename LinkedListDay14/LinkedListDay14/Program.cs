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
            list.AddAppend(56);
            list.AddAppend(70);
            list.InsertMiddle(30, 2);

            //list.Pop();
            list.RemoveLastNode();
            list.Search(30);
            list.Display();

            Console.ReadKey();
        }
    }
}
