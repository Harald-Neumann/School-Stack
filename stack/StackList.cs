using System;
using System.Collections;



namespace stack
{

    class StackList<T> : Stack<T>
    {
        class Node
        {
            public T value;
            public Node next;

            public Node(T value, Node next)
            {
                /// Erstellt eine neue Liste
                this.value = value;
                this.next = next;
            }
            public Node(T value)
            {
                this.value = value;
            }
        }
        Node top;
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
            Node tmp = new Node(v, top);
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
