using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPProject.structures.LinkedList
{
    public class MyNode
    {
        public MyNode Next { get; set; }
        public string PrepWord { get; set; }
        public int Frequency { get; set; }

        public MyNode(string prepWord,int frequency)
        {
            PrepWord = prepWord;
            Frequency = frequency;
        }




    }
}
