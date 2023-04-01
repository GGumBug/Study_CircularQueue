using System;
namespace CircularQueue
{
	public class CircularQueue<T>
	{
        private T[] elements;
        private int front, rear;

        public CircularQueue(int size)
        {
            elements = new T[size];
            front = rear = -1;
        }

        public bool IsEmpty()
        {
            return front == -1 && rear == -1;
        }

        public bool IsFull()
        {
            return (rear + 1) % elements.Length == front;
        }

        public void EnQueue(T item)
        {
            if (IsFull())
            {
                // 에러메세지를 던지다
                throw new Exception("Queue is empty");
            }
            else if (IsEmpty())
            {
                front = rear = 0;
            }
            else
            {
                rear = (rear + 1) % elements.Length;
            }

            elements[rear] = item;

        }

        public T DeQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue underflow");

                return default(T);
            }
            else if (front == rear)
            {
                T item = elements[front];
                front = rear = -1;
                return item;
            }
            else
            {
                T item = elements[front];
                front = (front + 1) % elements.Length;
                return item;
            }
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue empty");
                return;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write($"{elements[i]} ");
            }
            Console.WriteLine();
        }
    }
}

