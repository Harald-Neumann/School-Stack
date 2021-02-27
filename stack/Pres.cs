using System;
using System.Collections;

namespace stack
{
    class PNode
    {
        public int value;
        public PNode next;

        public PNode(int value, PNode next)
        {
            this.value = value;
            this.next = next;
        }
        public PNode(int value)
        {
            this.value = value;
        }
    }
    class PresList
    {
        PNode top;
        public PresList()
        {
            top = null;
        }

        public PresList(int i)
        {
            top = new PNode(i, null);
        }


        public void Push(int v)
        {
            PNode tmp = new PNode(v, top);
            top = tmp;
        }

        public int Pop()
        {
            if (IsEmpty()) throw new Exception("Stack is empty");
            int tmp = top.value;
            top = top.next;
            return tmp;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public int Peek()
        {
            return top.value;
        }
    }
}
