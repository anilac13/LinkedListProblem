using System.Collections.Generic;

namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose option to perform \n1.Create Linked list(Add to last) \n2.Display \n3.Add elements (Add to first) \n4.Append elements \n5.Insert between elements " +
                    "\n6.Delete first node \n7.Delete last node \n8.Search element \n9.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        linkedList.AddToLast(56);
                        linkedList.AddToLast(30);
                        linkedList.AddToLast(70);
                        break;
                    case 2:
                        linkedList.Display();
                        break;
                    case 3:
                        linkedList.AddToFirst(70);
                        linkedList.AddToFirst(30);
                        linkedList.AddToFirst(56);
                        break;
                    case 4:
                        linkedList.AddToLast(56);
                        linkedList.AddToLast(30);
                        linkedList.AddToLast(70);
                        break;
                    case 5:
                        linkedList.AddToLast(56);
                        linkedList.AddToLast(70);
                        linkedList.AddAfterElement(30, 56);
                        break;
                    case 6:
                        linkedList.DeleteFirstNode();
                        break;
                    case 7:
                        linkedList.DeleteLastNode();
                        break;
                    case 8:
                        linkedList.SearchElement(70);
                        break;
                    case 9:
                        flag = false;
                        break;
                }
            }
        }
    }
}