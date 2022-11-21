using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise_Linked_List_D
{
    class Node
    {
        /* cretes node for the circular nexted lisst*/
        public int rollNumber;
        public string name;
        public Node next;
    }

    class CircularList
    {
        Node LAST;

        public CircularList()
        {
            LAST = null;
        }

        public bool search(int rollNo, ref Node previous, ref Node current)
        /*Searches for the specified node*/
        {
            for (previous = current = LAST.next; current != LAST; previous = current, current = current.next)
            {
                if (rollNo == current.rollNumber)
                    return (true);/* returns true if the node is found*/
            } 
            if (rollNo == LAST.rollNumber)/* if the node is present at the end*/
                return true;
            else
                return false;/* return false if the node is not found*/
        }
        public bool listEmpty()
        {
            if (LAST == null)
                return true;
            else
                return false;
        }
        public void traverse()/* traverse all the nodes of the list*/
        {
            if (listEmpty())
                Console.WriteLine("\nList is empty");
            else
            {
                Console.WriteLine("\nRecord in the list are:\n");
                Node currentNode;
                currentNode = LAST.next;
                while (currentNode != LAST)
                {
                    Console.Write(currentNode.rollNumber + "  " + currentNode.name + "\n");
                    currentNode = currentNode.next; 
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
