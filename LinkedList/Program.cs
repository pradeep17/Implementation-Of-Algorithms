using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            
	   DoubleLink n1=new DoubleLink();
	   DoubleLink n2=new DoubleLink();
	  
	   for (int i = 3; i>0; i--)
		   n1.append(i);
	   for (int i = 2; i>0; i--)
		   n2.append(i);
	   n1.display();
	    n2.display();
	    
	    DoubleLink result  =new DoubleLink();
	    result.addLists(n1.head, n2.head);
	    
	    ListNode l1 = new ListNode();  
	  // for (int i = 4; i>0; i--)
		   l1.append(4);
		   l1.append(4);
		   l1.append(2);
	   l1.append(5);
	   l1.append(4);  
	   l1.append(2); 
	   l1.append(1); 
		  l1.delete(3);
		  ListNode.deleteDups2(l1.head);
		  l1.display();
          Console.ReadKey();
        }
    }

    //creation of Singly Linked list
    public class ListNode
    {
        public ListNode head = null;
        ListNode tail = null;
        ListNode next = null;
        int data;

        public void append(int d)
        {

            ListNode newnode = new ListNode();
            newnode.data = d;
            newnode.next = null;
            if (head == null)
            {
                head = newnode;
                tail = head;
            }
            else
                tail.next = newnode;
            tail = newnode;
        }
        public void display()
			{
				
				ListNode n = head;
				while(n != null){
                    Console.WriteLine("next element data = " + n.data);
				n=n.next;}
					
			}
        public void delete(int d)
		{
			ListNode newnode = head;
			while (newnode.next !=null && newnode.next.data != d)
			{
				newnode = newnode.next;
			
			}
			if(newnode.next!= null)
				newnode.next=newnode.next.next;
			else
                Console.WriteLine("Node not found!\n");
				
		}
        public static void deleteDups2(ListNode head)
        {
            if (head == null) return;
            ListNode previous = head;
            ListNode current = head.next;
            while (current != null)
            {
                ListNode runner = head;
                while (runner != current)
                { // Check for earlier dups

                    if (runner.data == current.data)
                    {
                        //ListNode tmp = current.next; // remove current
                        previous.next = current.next;
                        current = current.next; // update current to next node
                        break; // all other dups have already been removed
                    }
                    runner = runner.next;
                }
                if (runner == current)
                { // current not updated - update now
                    previous = current;
                    current = current.next;
                }
            }
        }
    }

    //creation of Doubly Linked list
    public class DoubleLink
    {
        public DoubleLink head = null;
        DoubleLink tail = null;
        DoubleLink next = null;
        DoubleLink previous = null;
        int data;

        public void append(int d)
        {
            DoubleLink newnode = new DoubleLink();
            newnode.data = d;
            newnode.next = null;
            newnode.previous = tail;
            if (head == null)
            {
                head = newnode;
                tail = head;
            }
            else
                tail.next = newnode;
            tail = newnode;
        }
        public void append()
        {
            DoubleLink newnode = new DoubleLink();
            newnode.data = this.data;
            newnode.next = null;
            newnode.previous = tail;
            if (head == null)
            {
                head = newnode;
                tail = head;
            }
            else
                tail.next = newnode;
            tail = newnode;
        }
        public void append(DoubleLink newnode)
        {

            newnode.next = null;
            newnode.previous = tail;
            if (head == null)
            {
                head = newnode;
                tail = head;
            }
            else
                tail.next = newnode;
            tail = newnode;
        }
        public void display()
			{
				
				DoubleLink n = head;
				while(n != null){
					Console.WriteLine("next element data = " + n.data);
				n=n.next;}
					
			}
        public void addLists(DoubleLink l1, DoubleLink l2)//, int carry
        {

            if (l1 == null && l2 == null)
            {
                return;
            }
            int carry = 0, value = 0;
            DoubleLink result = new DoubleLink();
            /*int value = carry;
            if (l1 != null) {
             value += l1.data;
                 }
                 if (l2 != null) {
                 value += l2.data;
                 }
                 result.data = value % 10;
                result.append();
                addLists(l1 == null ? null : l1.next,
                 l2 == null ? null : l2.next,
                 value > 10 ? 1 : 0);
                  result.display();*/
            while (l1 != null || l2 != null)
            {
                if (l1 != null)
                {
                    value += l1.data;
                }
                if (l2 != null)
                {
                    value += l2.data;
                }
                result.data = (value + carry) % 10;
                result.append();
                l1 = (l1 == null) ? null : l1.next;
                l2 = (l2 == null) ? null : l2.next;
                carry = (value > 10) ? 1 : 0;
                value = 0;
            }
            result.display();
        }
        public void removedups()
		{
			DoubleLink n = head;
			if(n == null)
			   Console.WriteLine("Error: No data present");
			else
			{
				while(n != null)
				{
					if(n.next.data == n.data)
					{
						n.next = n.next.next;
					}
                    n = n.next;
				}
			}
		}




    }

}
