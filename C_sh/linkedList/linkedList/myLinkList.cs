using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace linkedList
{
    public class Node<T>
    { 
        public T value{ get; private set; }
        public Node<T> previous { get;set;}
        public Node<T> next { get;set;}

        public Node(T value, Node<T>? next = null) { 
            this.value = value;
            this.next = next;
        }
    }

    internal class myLinkList<T>
    {
        public Node<T> head;
        public Node<T> tail;
        public int length = 1;

        public myLinkList(T value)
        {
            Node<T> newNode = new Node<T>(value);
            this.head = newNode;
            this.tail = newNode;
        }
        
        public void Append(T value) { 
            Node<T> newNode = new Node<T>(value);
            this.tail.next = newNode;
            this.tail = this.tail.next;
            this.length++;
        }

        public void Remove(T value) { 
           Node<T> previousNode = null;
           Node<T> currentNode = this.head;
           while(currentNode != null) { 
                if(currentNode.value.Equals(value)) {
                    previousNode.next = currentNode.next;
                    return;
                }
                previousNode = currentNode;
                currentNode = currentNode.next;
            }
        }

        public void Print() { 
            Node<T> currentNode = this.head; 
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.value);
                currentNode = currentNode.next;
            }
            Console.WriteLine();
        }
    }
}
