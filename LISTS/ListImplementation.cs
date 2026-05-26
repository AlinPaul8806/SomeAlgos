namespace SomeAlgos.Lists
{
    public class ListImplementation<T>
    {
        T[] items = new T[5];
        int count;

        public void Add(T item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }

            items[count++] = item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator(this);
        }

        class MyEnumerator : IEnumerator<T>
        {
            int index = -1;
            ListImplementation<T> theList;

            public MyEnumerator(ListImplementation<T> theList)
            {
                this.theList = theList;
            }

            public bool MoveNext()
            {
                return ++index < theList.count;
            }

            public T Current
            {
                get
                {
                    if (index < 0 || theList.count <= index)
                    {
                        return default(T);
                    }
                    return theList.items[index];
                }
            }

            public void Dispose()
            {
            }

            object System.Collections.IEnumerator.Current
            {
                get { return Current; }
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}
