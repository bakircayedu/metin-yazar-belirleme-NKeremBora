using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPProject
{
    public class WordInfo: IComparable<WordInfo>
    {
        public string PrepWord { get; set; }
        public int Frequency { get; set; }

        public WordInfo(string prepword, int frequency)
        {
            PrepWord = prepword;
            Frequency = frequency;

        }
        public WordInfo()
        {

        }
        public int CompareTo(WordInfo other)
        {
            if (this.Frequency < other.Frequency)
                return -1;
            if (this.Frequency == other.Frequency)
                return 0;
            return 1;
        }

        
    }
}
