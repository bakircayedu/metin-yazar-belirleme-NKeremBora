using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPProject.structures.HashTable
{
    public class MyHashTable
    {
        public HashNode[] Array { get; set; }
        public int Count { get; set; }

        public int Key { get; set; }
        public int Size { get; set; }
        public MyHashTable(int size)
        {
            Array = new HashNode[size];
            Size = size;
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = new HashNode();
            }
        }

        private int Hash(string prepword)
        {
            int hasVal = 0;
            foreach (var a in prepword)
                hasVal += a;
            return hasVal % Size;
        }
        public void Add(string prepWord, int frequency)
        {
            HashNode node = new(prepWord, frequency);
            int index = Hash(prepWord);

            if (Array[index].PrepWord == null)
            {
                Array[index] = node;
                return;
            }
            var temp = Array[index];
            while(temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = node;
            return;
        }

        public HashNode Find(string text) 
        {
            int index = Hash(text);
            var current = Array[index].Next;
            var temp = Array[index];
            if (temp.PrepWord == text)
            {
                return Array[index];
            }
            while (current != null)
            {
                if (current.PrepWord == text)
                {
                    return current;
                }
                current = current.Next;
                temp = temp.Next;
            }
            throw new Exception();
        }
        public void Delete(string text)
        {
            int index = Hash(text);
            var current = Array[index].Next;
            var temp = Array[index];

            if(temp.PrepWord == text)
            {
                temp = current;
                return;
            }
            while(current !=null)
            {
                if(current.PrepWord == text)
                {
                    temp.Next = current.Next;
                }
                current = current.Next;
                temp = temp.Next;
            }

        }
    }
}
