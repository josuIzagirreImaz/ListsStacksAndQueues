namespace Common
{

    public class GenericQueue<T> : IPushPop<T>
    {
        //TODO #1: Declare a List inside this object class to store the objects. Choose the most appropriate object class
        GenericList<T> MyList;

        public GenericQueue()
        {
            MyList = new GenericList<T>();
        }
        public string AsString()
        {
            //TODO #2: Return the list as a string. Use the method already implemented in your list
            return null;
        }

        public int Count()
        {
            //TODO #3: Return the number of objects
            return MyList.Count();
        }

        public void Clear()
        {
            //TODO #4: Remove all objects stored
            MyList.Clear();
        }

        public void Push(T value)
        {
            //TODO #5: Add a new object to the list (at the end of it)
            MyList.Add(value);
        }

        public T Pop()
        {
            //TODO #6: Remove the first object of the list and return it
            T tempo = MyList.Get(0);
            MyList.Remove(0);

            return tempo;
        }
    }
}