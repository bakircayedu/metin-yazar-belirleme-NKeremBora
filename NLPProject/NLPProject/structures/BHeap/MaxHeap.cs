using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPProject.structures.BHeap
{
    public class MaxHeap<T> : BHeap<T> where T : IComparable<T>
    {
        public MaxHeap() : base()
        {

        }
        public MaxHeap(int _size) : base(_size)
        {

        }
        public MaxHeap(IEnumerable<T> collection) : base(collection)
        {

        }

        protected override void HeapifyDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                var higherIndex = GetLeftChildIndex(index);
                if(HasRightChild(index) && 
                    GetRightChild(index).CompareTo(GetLeftChild(index)) > 0)
                {
                    higherIndex = GetRightChildIndex(index);
                }
                if (Array[higherIndex].CompareTo(Array[index]) < 0)
                {
                    break;
                }
                Swap(index, higherIndex);
                index = higherIndex;
            }
        }

        protected override void HeapifyUp()
        {
            var index = position - 1;
            while(!isRoot(index) && Array[index].CompareTo(GetParent(index)) > 0)
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            } 
        }

        
        
    }
}
