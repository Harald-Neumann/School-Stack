using System;

namespace stack
{
    /**<summary>
     * Used for testing/debuging
     * </summary>
     */
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new StackUnrolled<int>();
            for (var i = 0; i < 100; i++) s.Push(i);
            s.Push(1);
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Count);
            Console.WriteLine(s.IsEmpty());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            s.Push(12);
            s.Push(12);
            s.Push(12);
            s.Push(12);
            s.Push(12);
            for (var i = 0; i < 100; i++) Console.WriteLine(s.Pop());
            Console.WriteLine(s.IsEmpty());
            Console.WriteLine(s.Pop());
        }

    }
}