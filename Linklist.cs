using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPracticeProblem
{
        public class LinkedLists
        {
            public Node Head;
            public Node Tail;

            public void AddNode(int value)
            {
                Node node = new Node(value);
               
                if (Head == null & Tail == null)
                {
                    Head = node;
                    Tail = node;
                }
                else
                {                  
                    node.next = Head;
                    Head = node;
                }
                Console.WriteLine($" Added {value} at the linkedlist");
            }
            public void AppendNode(int value)
            {
                Node node = new Node(value);
                
                if (Head == null & Tail == null)
                {
                    Head = node;
                    Tail = node;
                }
                else
                {
                    Node temp = Head;
                   
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = node;
                }
                Console.WriteLine($"Added {value} at start of the linkedlist");
            }
            public bool Search(int value)
            {
                
                Node temp = Head;
               
                while (temp != null)
                {
                    
                    if (temp.data == value)
                    {
                        return true;
                    }
                    temp = temp.next;
                }
                return false;
            }
            public void InsertNode(int value, int Previousvalue)
            {
                Node newNode = new Node(value);
                if (Head == null & Tail == null)
                {
                    Head = newNode;
                }
                else
                {
                    Node temp = Head;
                    
                    while (temp.data != Previousvalue)
                    {
                        temp = temp.next;
                    }
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
            }
            public void DeleteNodeAtFirst()
            {
                if (Head == null & Tail == null)
                {
                    Console.WriteLine("Nothing to delete list is empty");
                }
                Node temp = Head;
                
                Head = Head.next;

                Console.WriteLine("Removed from linkedlist :" + temp.data);
            }

            public void DeleteNodeAtLast()
            {
                if (Head == null & Tail == null)
                {
                    Console.WriteLine("Nothing to delete list is empty");
                }
                Node temp = Head;
                
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                
                temp.next = null;
            }

            public int getCount()
            {
                Node temp = Head;
                int count = 0;
                while (temp != null)
                {
                    count++;
                    temp = temp.next;
                }
                return count;

            }
            public void deleteNode(int value)
            {                
                Node temp = Head, prev = null;
            
                if (temp != null && temp.data == value)
                {
                    // Changed head
                    Head = temp.next;
                    return;
                }

               
                while (temp != null && temp.data != value)
                {
                    prev = temp;
                    temp = temp.next;
                }               
                if (temp == null)
                    return;              
                prev.next = temp.next;
            }
            public void sort()
            {
                Node i, j;
                int temp;
                for (i = this.Head; i.next != null; i = i.next)
                {
                    for (j = i.next; j != null; j = j.next)
                    {
                        if (i.data > j.data)
                        {
                            temp = i.data;
                            i.data = j.data;
                            j.data = temp;
                        }
                    }
                }
            }
            internal void Display()
            {                
                Node temp = Head;                 
                if (temp == null)
                    Console.WriteLine("Linked list is empty");
                else
                    Console.WriteLine("Linked List:");
                while (temp != null)
                {                   
                    Console.Write(temp.data);
                    if (temp.next != null)
                        Console.Write(" -> ");                  
                    temp = temp.next;
                }

            }
        }
      
}
