using NLPProject.structures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPProject.structures.stack
{
    public class MyMyStack
    {
        private readonly MyMyLinkList list = new();
        public int Count { get; set; }
        public List<MyNode> Clone()
        {
            return list.Clone();
        }
        public MyNode Peek()
        {
            if (Count == 0)
                throw new Exception();
            return list.Head;
        }
        public MyNode Pop()
        {
            if (Count == 0)
                throw new Exception();
            Count--;
            return list.RemoveFirst();
        }
        public void Push(string prepWord,int frequency)
        {
            list.AddFirst(prepWord,frequency);
            Count++;
        }
     

    }
}
