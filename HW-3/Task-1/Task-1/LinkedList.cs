using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class LinkedList<T>
    {
        Node<T>? head;
        Node<T>? tail;
        int count;

        public void Add(T item)
        {
            Node<T> node = new Node<T>(item);
            
            if (head == null)
            {
                head = node;
            }
            else
            {
                tail!.next = node;
            }

            tail = node;
            count++;
        }

        public int Count { get { return count; } }

        public void AppendFirst(T item)
        {
            Node<T> node = new Node<T>(item);
            node.next = head;
            head = node;
            if (count == 0)
            {
                tail = node;
            }
            count++;
        }

        public void ReverseList()
        {
            Node<T> node = head!;
            Node<T> previous = null!;

            while (node !=  null)
            {
                Node<T> temp = node.next!;
                node.next = previous;
                previous = node;
                head = node;
                node = temp;
            }
        }

        public Node<T> First()
        {
            return head;
        }
    }
}
