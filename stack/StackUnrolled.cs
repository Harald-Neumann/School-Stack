using System;

namespace stack
{
    /**<summary>
     *Stack implementation based on an unrolled list 
     *</summary>
     */
    class StackUnrolled<T> : Stack<T>
    {
        class Node
        {
            public T[] array;
            public Node next;
            public int p;
            public Node(int i, Node n)
            {
                array = new T[i];
                p = -1;
                next = n;
                Console.WriteLine("New PNode Created");
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
        Node top;
        int n;
        public StackUnrolled()
        {
            top = new Node(10, top);
        }
        public override void Push(T v)
        {
            if (top.State() == 1) { top = new Node(10, top); n++; }
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
