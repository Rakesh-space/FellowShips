using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkeListProblem
{
    class UC5LinkedListProblem
    {
        internal Node head;

        internal void insert(int data) //inserting new integer data into linklist
        {
            Node new_node = new Node(data); //here create new_node allocate memory here and assinged the data
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node temp = head;  //here Node type of temp variable create and to assgined the head as a temp
                while (temp.next != null)
                {
                    temp = temp.next;  //temp.next node to assgined the temp variable
                }
                temp.next = new_node;  //temp.next is link to new_node
            }
            Console.WriteLine("\n {0} Data is inserted into linked list.", new_node.data);
        }


        internal Node RemoveFirst()  //Removing first element in given linklist
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next; //head is shift to the next node
            return this.head;
        }

        internal void DisplayAllEle() //display the data of linkedlist
        {
            Console.WriteLine("\nDisplay LinkedList element is:");
            Node temp = this.head;
            if (temp == null)  //cheking the linklinst is empty or not
            {
                Console.WriteLine("\n Linked List empty");
                return;
            }
            else
            {
                while (temp != null) //display the linklist data
                {
                    Console.WriteLine(temp.data + " ");  //actual new_node of data can be display
                    temp = temp.next;  //temp variable shift to the next node
                }
                //  Console.WriteLine(" " + temp.data + " ");
            }
        }
    }
}
