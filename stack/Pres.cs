using System;
using System.Collections;

namespace stack
{
    /**<summary>
     * Node class used in PresList.  
     * </summary>
     * 
     * <remarks>
     * The Node was renamed to PNode to make it more distinguished from other (nested) Nodeclasse.
     * 
     * For Informations about the Presentation see <see cref="PresList"/>.
     * </remarks>
     */
    class PNode
    {
        /// The Value of the Node
        public int value;

        /// A reference to the next Node 
        public PNode next;



        public PNode(int value, PNode next)
        {
            this.value = value;
            this.next = next;
        }
    }
    /**<summary>
     * Simplified version of the StackList class for use in the Presentation.
     * </summary>
     * <remarks>
     * List of changes:
     * <list type="bullet">
     * <item>
     * TODO
     * </item>
     * </list>
     *
     * The Presentation is not available to the public and only meant for use in school.
     * </remarks>
     */
    class PresList
    {
        PNode top;


        /**<summary>
        * Creates an empty stack 
        * </summary>
        */
        public PresList()
        {
            top = null;
        }
        /**<summary>
         * Creates a stack and pushes i onto it 
         * </summary>
         * <remarks>
         * <param name="i">int which will be pushed onto the stack</param>
         * </remarks>
         */
        public PresList(int i)
        {
            top = new PNode(i, null);
        }


        /**<summary>
        * Pushes the value onto the stack
        * </summary>
        * <remarks>
        * <param name="v">Takes a value to push it to the top of the stack</param>
        * </remarks>
        */
        public void Push(int v)
        {
            top = new PNode(v, top);
        }


        /**<summary>
         * Returns True if stack is empty.
         * </summary>
         */
        public bool IsEmpty()
        {
            return top == null; //When the stack is empty the reference does not point to a Node.
        }


        /**<summary>
         * Returns the value of the top and removes it.
         * </summary>
         * <remarks>
         * <returns>
         * The top value.
         * </returns>
         * <exception cref="Exception">Throws an exception if the stack is empty</exception>
         * </remarks>
         */
        public int Pop()
        {
            if (IsEmpty()) throw new Exception("Stack is empty");
            int tmp = top.value;
            top = top.next;
            return tmp;
        }


        /**<summary>
         * Returns the value of the top (but does not removes it).
         * </summary>
         * <remarks>
         * <returns>
         * The top value.
         * </returns>
         * <exception cref="Exception">Throws an exception if the stack is empty</exception>
         * </remarks>
         */
        public int Peek()
        {
            if (IsEmpty()) throw new Exception("Stack is empty");
            return top.value;
        }
    }
}
