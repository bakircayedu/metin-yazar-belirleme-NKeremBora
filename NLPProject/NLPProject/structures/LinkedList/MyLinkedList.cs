using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPProject.structures.LinkedList
{
    public class MyLinkedList
    {
        private bool _isHeadNull => Head == null;
        public Node Head;
        public int Size { get; set; }


        public void AddFirst(string value, int sentenceCount, string prepValue)
        {
            Node newNode = new(value, sentenceCount, prepValue);
            if (_isHeadNull)
            {
                Head = newNode;
                Size++;
                return;
            }
            newNode.Next = Head;
            Head = newNode;
            Size++;
        }
       
        public void AddFirst(string value, int frequency)
        {
            Node newNode = new(value, frequency);
            if (_isHeadNull)
            {
                Head = newNode;
                Size++;
                return;
            }
            newNode.Next = Head;
            Head = newNode;
            Size++;
        }
        public void AddFirst(string value, int frequency, string prepValue, int sentenceCount)
        {
            Node newNode = new(value, frequency, prepValue, sentenceCount);
            if (_isHeadNull)
            {
                Head = newNode;
                Size++;
                return;
            }
            newNode.Next = Head;
            Head = newNode;
            Size++;
        }
        public void AddLast(string value)
        {
            var current = Head;
            Node newNode = new(value);
            if (_isHeadNull)
            {
                Head = newNode;
                Size++;
                return;
            }
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
            Size++;
        }

        public void AddAfter(Node node, string value, int i)
        {
            if (node == null) throw new ArgumentNullException();
            if (_isHeadNull)
            {
               // AddFirst(value, i);
                return;
            }

            Node newNode = new(value);
            var current = Head;

            while (current != null)
            {
                if (current.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    Size++;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("the reference node is not in this list.");
        }

        public void AddBefore(Node node, string value, int i)
        {
            if (node == null) throw new ArgumentNullException();
            if (_isHeadNull)
            {
               // AddFirst(value, i);
                return;
            }
            if (Head == node)
            {
              //  AddFirst(value, i);
                return;
            }
            Node newNode = new(value);
            var current = Head.Next;
            var temp = Head;
            while (current != null)
            {
                if (current.Equals(node))
                {
                    newNode.Next = current;
                    temp.Next = newNode;
                    Size++;
                    return;
                }
                temp = temp.Next;
                current = current.Next;
            }
        }

        public string RemoveFirst()
        {
            if (_isHeadNull) throw new Exception("Underflow! Nothing to remove.");

            var firstValue = Head.Value;
            Head = Head.Next;
            return firstValue;

        }

        public string RemoveLast()
        {
            if (_isHeadNull) throw new Exception("Underflow! Nothing to remove.");

            var current = Head;
            var temp = Head;
            string lastValue;
            if (current.Next == null)
            {
                lastValue = Head.Value;
                Head = null;
                return lastValue;
            }
            while (current.Next != null)
            {
                temp = current;
                current = current.Next;
            }
            lastValue = current.Value;
            temp.Next = null;
            return lastValue;
        }

        public void Remove(string value)
        {
            if (_isHeadNull) throw new Exception("Underflow! Nothing to remove.");
            if (value == null) throw new ArgumentNullException();
            var current = Head.Next;
            var temp = Head;
            if (Head.Value.Equals(value))
            {
                Head = current;
                return;
            }
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    temp.Next = current.Next;
                    return;
                }
                current = current.Next;
                temp = temp.Next;
            }
        }

        public List<Node> Clone()
        {
            var clone = new List<Node>();
            var temp = Head;
            while(temp != null)
            {
                clone.Add(temp);
                temp = temp.Next;
                
            }
            return clone;

        }


        
    }
}
