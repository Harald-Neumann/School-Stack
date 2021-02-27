using System;
using System.Collections;

namespace stack
{
    class StackArray<T> : Stack<T>
    {
        public T[] array;
        int top;
        public int Max { get; set; }
        public override int Count => top + 1;
        public StackArray(int a)
        {
            array = new T[a];
            top = -1;
            Max = 128;
        }
        public StackArray()
        {
            array = new T[10];
            top = -1;
            Max = 128;
        }

        public StackArray(ICollection a)
        {
            array = new T[a.Count];
            a.CopyTo(array, 0);
            top = array.Length - 1;
        }

        public override T Pop()
        {
            if (top < 0) throw new Exception("Stack is Empty");
            else if (top < (array.Length / 2 - 5)) Array.Resize(ref array, array.Length / 2);
            else if (top < array.Length - Max - 5) Array.Resize(ref array, array.Length - Max);
            return array[top--];
        }
        public override void Push(T v)
        {
            if (array.Length < top + 2) Array.Resize(ref array, array.Length + Math.Min(Max, array.Length));
            array[++top] = v;
        }

        public override T Peek()
        {
            if (top < 0) throw new Exception("Stack is Empty");
            return array[top];
        }

        public override bool IsEmpty()
        {
            return (top < 0);
        }

    }
}
