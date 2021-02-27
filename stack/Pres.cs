using System;
using System.Collections;

namespace stack
{
    class PresList
    {
        class Note
        {
            public int value;
            public Note next;

            public Note(int value, Note next)
            {
                this.value = value;
                this.next = next;
            }
            public Note(int value)
            {
                this.value = value;
            }
        }
        Note top;
        public PresList()
        {
            top = null;
        }

        public PresList(int i)
        {
            top = new Note(i, null);
        }


        public void Push(int v)
        {
            Note tmp = new Note(v, top);
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
