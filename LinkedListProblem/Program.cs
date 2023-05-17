using System.Collections.Generic;

namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddToLast(56);
            linkedList.AddToLast(30);
            linkedList.AddToLast(70);
            linkedList.Display();
        }
    }
}