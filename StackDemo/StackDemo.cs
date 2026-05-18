namespace SomeAlgos.Stack
{
    public class StackDemo<T>
    {
        private T[] items;
        private int pointer = 0;

        public StackDemo(int size) 
        {
            items = new T[size];
        }

        public void Push(T value) 
        {
            items[pointer++] = value;
        }

        public T Pop()
        {
            return items[--pointer];
        }
    }
}
