using System;
namespace CircularQueue
{
	public class Program
	{
        static void Main(string[] args)
        {
            CircularQueue<int> circularQueue = new CircularQueue<int>(5);

            circularQueue.EnQueue(1);
            circularQueue.EnQueue(2);
            circularQueue.EnQueue(3);
            circularQueue.EnQueue(4);
            circularQueue.EnQueue(5);
        }
	}
}

