using System;

namespace stack
{
    class StackUnrolled<T> : Stack<T>
    {
        class Note
        {
            public T[] array;
            public Note next;
            public int p;
            public Note(int i, Note n)
            {
                array = new T[i];
                p = -1;
                next = n;
                Console.WriteLine("New Note Created");
            }
            public int State()
            {
                if (p + 1 >= array.Length) return 1;
                else if (p < 0) return -1;
                else return 0;
            }
            public void Put(T v)
            {
                array[++p] = v;
            }
            public T Get()
            {
                return array[p--];
            }
        }
        public override int Count { get => n*10 + top.p + 1; }
        Note top;
        int n;
        public StackUnrolled()
        {
            top = new Note(10, top);
        }
        public override void Push(T v)
        {
            if (top.State() == 1) { top = new Note(10, top); n++; }
            top.Put(v);
        }

        public override T Pop()
        {
            if (top.State() == -1 && top.next != null) { top = top.next; n--; }
            else if (top.State() == -1 && top.next == null) throw new Exception("Stack is Empty");
            return top.Get();
        }

        public override T Peek()
        {
            T tmp = top.Get();
            top.Put(tmp);
            return tmp;
        }

        public override bool IsEmpty()
        {
            return top.next == null && top.State() == -1;
        }
    }
}
