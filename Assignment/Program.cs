namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Queue<int> queue = new Queue<int>();  
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //Helper<int>.QueueRev(queue);

            //int Count = queue.Count;
            //for (int i = 0; i < Count; i++)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}
            #endregion
        }
    }

    public class Helper <T>
    {
        #region Q1 Given a Queue, implement a function to reverse the elements of a queue using a stack.
        static public void QueueRev(Queue<T> Q)
        {
            if (Q.Count > 0)
            {
                int Count = Q.Count;
                Stack<T> stack = new Stack<T>();
                for (int i = 0; i < Count; i++)
                {
                    stack.Push(Q.Dequeue());
                }
                for (int i = 0; i < Count; i++)
                {
                    Q.Enqueue(stack.Pop());
                }
            }
        }
        #endregion
    }
}
