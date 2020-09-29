using System;
using System.Collections.Generic;
using System.Text;

namespace SeperateChaining
{
    class SingleLinkedList
    {
        private Node start;
        
        public SingleLinkedList()
        {
            start = null;
        }

        public void displayList()
        {
            Node p;
            if (start == null)
            {
                Console.WriteLine("___");
                return;
            }
            p = start;
            while (p != null)
            {
                Console.Write(p.info.tostring() + " ");
                p = p.link;
            }
            Console.WriteLine();
        }

        public studentRecord Search(int x)
        {
            Node p = start;
            while (p != null)
            {
                if (p.info.getstudentId() == x)
                    break; ;
                p = p.link;
            }

            if (p == null)
            {
                Console.WriteLine(x + "Not found in the list");
                return null;
            }
            else
                return p.info;
        }

        public void insertInBeginning(studentRecord data)
        {
            Node temp = new Node(data);
            temp.link = start;
            start = temp;
        }

        public void deleteNode(int x)
        {
            if (start == null)
            {
                Console.WriteLine("Value" + x + "Not present\n");
                return;
            }
            if (start.info.getstudentId()== x)
            {
                start = start.link;
                return;
            }
            Node p = start;
            while (p.link != null)
            {
                if (p.link.info.getstudentId() == x)
                
                    break;
                    p = p.link;
                
               
            }
            if (p.link == null)
            
                Console.WriteLine("Value" + x + " is not present\n");

            
            else
            
                p.link = p.link.link;
            
        }
    }
}
