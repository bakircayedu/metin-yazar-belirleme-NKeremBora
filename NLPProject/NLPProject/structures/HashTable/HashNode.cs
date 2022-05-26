using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPProject.structures.HashTable
{
    public class HashNode
    {
        public HashNode Next { get; set; }
        public string PrepWord { get; set; }
        public int Frequency { get; set; }

        public HashNode( string prepword, int frequency)
        {
            PrepWord = prepword;
            Frequency = frequency;

        }
        public HashNode()
        {

        }
    }

    
}
