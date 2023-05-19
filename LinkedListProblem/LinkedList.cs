using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class LinkedList
    {
        private Node head;
        public void AddToLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
        }
        public void AddToFirst(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node prevHead = head;
            head = newNode;
            head.next = prevHead;
        }
        public void AddAfterElement(int data, int afterWhich)
        {
            Node newNode = new Node(data);
            if (head == null)
                return;
            Node temp = head;
            while (temp.data != afterWhich)
            {
                temp = temp.next;
            }
            newNode.next = temp.next;
            temp.next = newNode;
        }
        public void DeleteFirstNode()
        {
            if (head == null)
                return;
            Node secondNode = head.next;
            head = secondNode;
        }
        public void DeleteLastNode()
        {
            if (head == null)
                return;
            Node secondLast = head;
            Node lastNode = head.next;
            while (lastNode.next != null)
            {
                secondLast = lastNode;
                lastNode = lastNode.next;
            }
            secondLast.next = null;
        }
        public void SearchElement(int value)
        {
            Node node = head;
            int count = 0;
            while (node != null)
            {
                if (node.data == value)
                {
                    Console.WriteLine(count);
                }
                node = node.next;
                count++;
            }
        }
        public void Delete(int data)
        {
            Node prevNode = head;
            Node currentNode = head.next;
            while (currentNode.data != data)
            {
                if (currentNode.next == null)
                {
                    Console.WriteLine($"The {data} element is not there in Linked list");
                    return;
                }
                prevNode = currentNode;
                currentNode = currentNode.next;
            }
            prevNode.next = currentNode.next;
        }
        public void SortElements()
        {
            Node head1 = new Node(0);
            Node head2 = new Node(0);

            SplitList(head1, head2);

            head1 = head1.next;
            head2 = head2.next;
            head2 = ReverseList(head2);
            head = MergeList(head1, head2);
        }

        private Node MergeList(Node head1, Node head2)
        {
            if (head1 == null)
                return head2;
            if (head2 == null)
                return head1;
            Node temp = null;
            if (head1.data < head2.data)
            {
                temp = head1;
                head1.next = MergeList(head1.next, head2);
            }
            else
            {
                temp = head2;
                head2.next = MergeList(head1, head2.next);
            }
            return temp;
        }

        private Node ReverseList(Node head2)
        {
            Node current = head2;
            Node prev = null;
            Node next;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head2 = prev;
            return head2;
        }

        private void SplitList(Node head1, Node head2)
        {
            Node ascend = head1;
            Node descend = head2;
            Node current = head;
            while (current != null)
            {
                ascend.next = current;
                ascend = ascend.next;
                current = current.next;
                if (current != null)
                {
                    descend.next = current;
                    descend = descend.next;
                    current = current.next;
                }
            }
            ascend.next = null;
            descend.next = null;
        }

        public void Display()
        {
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            Console.Write("Elements in Linked list are: ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
