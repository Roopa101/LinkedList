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
            //Appends the Nodes
            list.AddAppend(56);
            list.AddAppend(30);
            list.AddAppend(70);
            list.Display();
            Console.ReadKey();
        }
    }
}
        