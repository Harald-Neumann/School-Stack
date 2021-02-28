using System;
using System.Collections;

namespace stack
{
    /**<summary>
     *Node class used in PresList.  
     *</summary>
     * 
     * The Node was renamed to PNode to make it more distinguished from other (nested) Nodeclasse.
     * 
     * For Informations about the Presentation see <see cref="PresList"/>.
     */
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
    /**<summary>
     *Simplified version of the StackList class for use in the Presentation 
     *</summary>
     *
     *List of changes:
     *<list type="bullet">
     *<item>
     *TODO
     *</item>
     *</list>
     *
     *The Presentation is not available to the public and only meant for use in school.
     */
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
