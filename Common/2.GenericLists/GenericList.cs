using Common;

public class GenericListNode<T>
{
    public T Value;
    public GenericListNode<T> Next = null;

    public GenericListNode(T value)
    {
      Value = value;
    }

    public override string ToString()
    {
      return Value.ToString();
    }
}

public class GenericList<T> : IGenericList<T>
{
    GenericListNode<T> First = null;
    private int NumElements = 0;
    GenericListNode<T> Last = null;

    public string AsString()
    {
      GenericListNode<T> node = First;
      string output = "[";

      while (node != null)
      {
        output += node.ToString() + ",";
        node = node.Next;
      }
      output = output.TrimEnd(',') + "] " + Count() + " elements";
      
      return output;
    }

    public void Add(T value)
    {
        //TODO #1: add a new element to the end of the list
        if (First == null)
        {
            First = new GenericListNode<T>(value);
            Last = First;
        }
        else
        {


            Last.Next = new GenericListNode<T>(value);

            Last = Last.Next;

        }
        NumElements++;
     }

    public GenericListNode<T> FindNode(int index)
    {
        //TODO #2: Return the element in position 'index'

        int currentPos = 0;
        GenericListNode<T> currentNode = First;
        while (currentPos < index && currentNode.Next != null)
        {
            currentNode = currentNode.Next;
            currentPos++;
        }
        if (currentPos == index)
        {
            return currentNode;
        }
        return null;
    }

    public T Get(int index)
    {
        //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). Return the default value for object class T if the position is out of bounds

        if (FindNode(index) == null)
        {
            return default;
        }
        else
        {
            return FindNode(index).Value;
        }
    }
    public int Count()
    {
        //TODO #4: return the number of elements on the list

        return NumElements;
    }


    public void Remove(int index)
    {
        //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
        if (index >= NumElements)
        {
            return;
        }
        else
        {

            if (NumElements == 1 && index == 0)
            {
                First = null;
            }
            else if (NumElements > 1 && index == 0)
            {

                First = First.Next;


            }
            else
            {

                int currentPos = 0;
                GenericListNode<T> currentNode = First;
                GenericListNode<T> anteriorNode = First;
                while (currentNode != null || currentPos < NumElements)
                {


                    anteriorNode = currentNode;
                    currentNode = currentNode.Next;
                    currentPos++;
                }
                if (currentPos == index)
                {
                    anteriorNode.Next = currentNode.Next;
                }
            }
            NumElements--;
        }
    }

    public void Clear()
    {
            //TODO #6: remove all the elements on the list
            First = null;
            NumElements = 0;
    }
}