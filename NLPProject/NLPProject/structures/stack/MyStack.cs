using NLPProject.structures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPProject.structures.stack
{
    public class MyStack
    {
        private readonly MyLinkedList list = new();
        public int Count { get; set; }
        public List<Node> Clone()
        {
            return list.Clone();
        }
        public Node Peek()
        {
            if (Count == 0)
                throw new Exception();
            return list.Head;
        }
        public string Pop()
        {
            if (Count == 0)
                throw new Exception();
            Count--;
            return list.RemoveFirst();
        }
        public void Push(string value, int sentenceCount, string prepValue) 
        {
            if (value == null)
                throw new Exception();
            list.AddFirst(value, sentenceCount, prepValue);
            Count++;
        }
        public void Push(string value, int sentenceCount, string prepValue, int insentenceCount)
        {
            if (value == null)
                throw new Exception();
            list.AddFirst(value, sentenceCount, prepValue, insentenceCount);
            Count++;
        }
        public void Push(string value, int frequency)
        {
            if (value == null)
                throw new Exception();
            list.AddFirst(value, frequency);
            Count++;
        }

    }
}
