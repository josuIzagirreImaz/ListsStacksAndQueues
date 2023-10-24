using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.ExceptionServices;

namespace Common
{
    public class IntListNode
    {
        public int Value;
        public IntListNode Next = null;

        public IntListNode(int value)
        {
            Value = value;
        }
    }

    public class IntList : IList
    {
        IntListNode First = null;
        private int NumElements = 0;
        IntListNode Last = null;
        //This method returns all the elements on the list as a string
        //Use it as an example on how to access all the elements on the list
        public string AsString()
        {
            IntListNode node = First;
            string output = "[";

            while (node != null)
            {
                output += node.Value + ",";
                node = node.Next;
            }
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }


        public void Add(int value)
        {
            //TODO #1: add a new integer to the end of the list
            if (First == null)
            {
                First = new IntListNode(value);
                Last = First;
            }
            else
            {
                
                
                Last.Next = new IntListNode(value);
                
                Last = Last.Next;




                //nodeA = First;
                //while (nodeA.Next != null)
                //{
                 //   nodeA = nodeA.Next;
                //}
                //nodeA.Next = new IntListNode(value);
               
            }
            NumElements++;

        }

        private IntListNode GetNode(int index)
        {
            //TODO #2: Return the element in position 'index'
            int currentPos = 0;
            IntListNode currentNode = First;
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


        public int Get(int index)
        {
            //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). O if the position is out of bounds
            if (GetNode(index) == null)
            {
                return 0;
            }
            else
            {
                return GetNode(index).Value;
            }

        }


        public int Count()
        {
            //TODO #4: return the number of elements on the list
            //int currentPos = 0;
            //IntListNode currentNode = First;
            //while (currentNode.Next != null)
            //{
            //currentNode = currentNode.Next;
            //currentPos++;
            //}
            //return (currentPos);
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

                if (NumElements == 1 && index==0)
                {
                    First = null;
                }
                else if(NumElements >1 && index ==0){

                    First = First.Next;


                }
                else
                {

                    int currentPos = 0;
                    IntListNode currentNode = First;
                    IntListNode anteriorNode = First;
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
}

