using NLPProject.structures.stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPProject
{
    public class NLPFunctions
    {
        public MyStack GetRidOfPunctuationSigns(MyStack _stack)
        {
            MyStack resultStack = new();
            foreach(var node in _stack.Clone())
            {
                var sb = new StringBuilder();
                var word = node.Value;
                word = word.ToLower();
                    foreach (char c in word)
                    {
                        if (char.IsPunctuation(c))
                            break;
                        sb.Append(c);
                    }
                if (sb.Length == 0)
                    continue;

                resultStack.Push(word, node.SentenceCount, sb.ToString());

            }
            return resultStack;
        }

        public MyMyStack FindUniqueWord(MyStack _stack)
        {
            MyMyStack myStack = new();
            List<string[]> realWords = new();
            List<int[]> locationTexts = new();
            List<int[]> locationSentences = new();
            var list = _stack.Clone();
            var output = list.GroupBy(x => x.PrepValue).Select(x => new WordInfo { PrepWord = x.Key, Frequency = x.Count() }).OrderByDescending(x => x.Frequency).ToArray();
         
            int index = 0;
            foreach (var word in output)
                myStack.Push(word.PrepWord,word.Frequency);
            
            return myStack;
        }








    }
}
