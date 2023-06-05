using System;

namespace DataStructureProblemUsingGenerics
{
    internal class UC_1Queue
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

        public class Queue<T>
        {
            private Node<T> front;
            private Node<T> rear;

            public bool IsEmpty()
            {
                return front == null;
            }

            public void Enqueue(T value)
            {
                Node<T> newNode = new Node<T>(value);
                if (IsEmpty())
                {
                    front = newNode;
                    rear = newNode;
                }
                else
                {
                    rear.Next = newNode;
                    rear = newNode;
                }
            }

            public T Dequeue()
            {
                if (IsEmpty())
                {
                    return default(T); // Queue is empty, return default value of type T
                }
                else
                {
                    T value = front.Value;
                    front = front.Next;
                    if (front == null)
                    {
                        rear = null; // If the last element is dequeued, reset rear to null
                    }
                    return value;
                }
            }

            public T Peek()
            {
                if (IsEmpty())
                {
                    return default(T); // Queue is empty, return default value of type T
                }
                else
                {
                    return front.Value;
                }
            }
        }

        public static void Main(string[] args)
        {
            // Create a queue and enqueue elements
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);

            // Dequeue elements from the queue until it is empty
            while (!queue.IsEmpty())
            {
                Console.WriteLine("Peek: " + queue.Peek());
                Console.WriteLine("Dequeue: " + queue.Dequeue());
                Console.WriteLine("---------------");
            }
        }
    }
}
