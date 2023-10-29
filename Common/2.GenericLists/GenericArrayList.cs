using System;
namespace Common
{
    public class GenericArrayList<T> : IGenericList<T>
    {
        T[] Values;
        int NumElements = 0;

        public GenericArrayList(int n)
        {
            //TODO #1: initialize Values with an array of size n
            Values = new T[n];
        }
        public string AsString()
        {
            string output = "[";

            for (int i = 0; i < Count(); i++)
                output += Values[i].ToString() + ",";
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }

        

        public void Add(T value)
        {
            //TODO #2: add a new element to the end of the list
            if (NumElements == Values.Length)
            {

            }
            else
            {
                Values[NumElements] = value;
                NumElements++;
            }
        }

        public T Get(int index)
        {
            //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). Return the default value for object class T if the position is out of bounds
            
            return Values[index];
        }

        public int Count()
        {
            //TODO #4: return the number of elements on the list

            return NumElements;
        }

        public void Remove(int index)
        {
            //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
            if (index > Values.Length)
            {
                return;
            }
            else
            {
                
                    for (int cont = index; cont < NumElements-1; cont++)
                    {
                        Values[cont] = Values[cont + 1];
                    }
                    NumElements--;
              
            }
        }

        public void Clear()
        {
            //TODO #6: remove all the elements on the list
            NumElements = 0;
        }
    }
}