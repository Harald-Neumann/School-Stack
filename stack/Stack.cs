using System;
using System.Collections.Generic;
using System.Text;

namespace stack
{
     /**<summary>
     *abstract class used instead of an interface 
     *</summary>
     */
    abstract class Stack<T>
    {
        private int count;

        virtual public int Count
        {
            get { return count; }
            protected set { count = value; }
        }

        abstract public void Push(T v);
        abstract public T Pop();
        abstract public T Peek();
        abstract public bool IsEmpty();
    }
}
