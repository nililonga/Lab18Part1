using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    public class LinkedList
    {
        private Node head;
        private Node current;//This will have latest node
        public int Count;

        public LinkedList()
        {
            head = null;
            current = null;
            Count = 0;
        }

        public void AddAtStart(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;

            //first time--list is empty
            if (head == null)
            {
                newNode.Next = null;

                //only one node--both the start (head) and end (current)
                head = newNode;
                current = newNode;
            }
            else //not my first rodeo
            {
                newNode.Next = head;
                head = newNode;
                //current is correct--don't change
            }
            //could reset head = newNode here
            Count++;
        }

        public void AddToEnd(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            newNode.Next = null; //it's actually null by default

            //first time
            if (head == null)
            {
                //only one node--both the start (head) and end (current)
                head = newNode;
                current = newNode;
            }
            else //every other time (list has something)
            {
                //point the old last item to this as its next
                current.Next = newNode;
                //tell the list this is its last (current)
                current = newNode;
            }
            Count++;
        }

        public void RemoveFromStart()
        {
            if (Count == 1)
            {
                //back to an empty list
                head = null;
                current = null;
                Count = 0;
            }
            else if (Count > 1)
            {
                head = head.Next;
            }
            else
            {
                //really we want to throw an exception here
                Console.WriteLine("No elements in list");
            }
        }

        public void PrintAllNodes()
        {
            //start at the first node
            //console.writeline the node's value
            //go to the next node
            Node thisNode = head;
            while (thisNode != null)
            {
                Console.WriteLine(thisNode.Value);
                thisNode = thisNode.Next;
            }
        }
        public Node removeAll(Object o)
        {
            Node theNode = new Node();
            theNode.Next = head;

            Node blue = theNode;
            while (blue.Next != null)
            {
                if (blue.Next.Value == o)
                {
                    blue.Next = blue.Next.Next;
                }
                else
                {
                    blue = blue.Next;
                }
            }

            return theNode.Next;
        


        }

     }
    
}
    

