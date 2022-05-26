using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPProject.structures.LinkedList
{
    public class Node
    {
        public Node Next { get; set; }
        public String Value { get; set; }
        public String PrepValue { get; set; }
        public int SentenceCount { get; set; }
        public int InSentenceCount { get; set; }
        public int WordCount => a();
        public int Frequency { get; set; }
        public Node(String _value, int _sentenceCount, String _prepValue)
        {
            Value = _value;
            SentenceCount = _sentenceCount;
            PrepValue = _prepValue;
        }
        public Node(String _prepvalue, int frequency)
        {
            PrepValue = _prepvalue;
            Frequency = frequency;
        }
        public Node(String _value, int _sentenceCount, String _prepValue, int _insentenceCount)
        {
            Value = _value;
            SentenceCount = _sentenceCount;
            InSentenceCount = _insentenceCount;
        }
        public Node(String _value)
        {
            Value = _value;
        }
        private int a()
        {
            return Value.Split(' ').Length;
        }
        public override string ToString() => $"{Value}";


    }
}
