namespace NLPProject.structures.LinkedList
{
    public class MyMyLinkList 
    { 
    private bool _isHeadNull => Head == null;
    public MyNode Head;
    public int Size { get; set; }


    public void AddFirst(string prepWord,int frequency)
    {
        MyNode newNode = new(prepWord, frequency);
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

        public MyNode RemoveFirst()
    {
        if (_isHeadNull) throw new Exception("Underflow! Nothing to remove.");

        var firstValue = Head;
        Head = Head.Next;
        return firstValue;

    }

   

    
    public List<MyNode> Clone()
    {
        var clone = new List<MyNode>();
        var temp = Head;
        while (temp != null)
        {
            clone.Add(temp);
            temp = temp.Next;

        }
        return clone;

    }



}
}
