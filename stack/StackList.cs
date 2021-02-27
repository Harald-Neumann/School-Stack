using System;
using System.Collections;



namespace stack
{

    class StackList<T> : Stack<T>
    {
        class Note
        {
            public T value;
            public Note next;

            public Note(T value, Note next)
            {
                /// Erstellt eine neue Liste
                this.value = value;
                this.next = next;
            }
            public Note(T value)
            {
                this.value = value;
            }
        }
        Note top;
        public StackList()
        {
            top = null;
        }
        
        public StackList(int i)
        {
            top = null;
        }

        // Unschön
        public StackList(ICollection a)
        {
            T[] ar = new T[a.Count];
            a.CopyTo(ar, 0);
            for (var i = 0; i < ar.Length; i++) this.Push(ar[i]);
        }

        public override void Push(T v)
        {
            Note tmp = new Note(v, top);
            top = tmp;
            Count++;
        }

        public override T Pop()
        {
            if (top == null) throw new Exception("Stack is empty");
            T tmp = top.value;
            top = top.next;
            Count--;
            return tmp;
        }

        public override bool IsEmpty()
        {
            return top == null;
        }

        public override T Peek()
        {
            return top.value;
        }
    }
}
