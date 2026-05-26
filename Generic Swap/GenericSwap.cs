using System;

namespace SomeAlgos.Generic_Swap
{
    public class GenericSwap<T>
    {
        public T First { get; set; }
        public T Second { get; set; }

        public GenericSwap(T first, T second)
        {
            First = first;
            Second = second;
        }

        public void Swap()
        {
            T temp = First;
            First = Second;
            Second = temp;
        }
    }
}
