using System;

namespace DataStructureProblemUsingGenerics
{
    internal class UC_1Stack
    {
        public class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }

            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }

        public class Stack<T>
        {
            private Node<T> top;

            public bool IsEmpty()
            {
                return top == null;
            }

            public void Push(T value)
            {
                Node<T> newNode = new Node<T>(value);
                if (IsEmpty())
                {
                    top = newNode;
                }
                else
                {
                    newNode.Next = top;
                    top = newNode;
                }
            }

            public T Pop()
            {
                if (IsEmpty())
                {
                    return default(T); // Stack is empty, return default value of type T
                }
                else
                {
                    T value = top.Value;
                    top = top.Next;
                    return value;
                }
            }

            public T Peek()
            {
                if (IsEmpty())
                {
                    return default(T); // Stack is empty, return default value of type T
                }
                else
                {
                    return top.Value;
                }
            }
        }

        public static void Main(string[] args)
        {
            // Create a stack and push elements
            Stack<int> stack = new Stack<int>();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);

            // Pop elements from the stack
            Console.WriteLine(stack.Pop()); // Output: 56
        }
    }
}
