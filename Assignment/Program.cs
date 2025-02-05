using System.Net.Http.Headers;
using System.Reflection;

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

            #region Q2

            //string str = "[()]{}";

            //Console.WriteLine(Helper<string>.ParenthesesCheck(str));

            #endregion
        }
    }

    public class Helper<T>
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

        #region Q2 Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

        static public string ParenthesesCheck(string str)
        {
            if (str is not null)
            {
                bool Flag = false;
                Stack<char> stack = new Stack<char>();

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '(' || str[i] == ')' || str[i] == '{' || str[i] == '}' || str[i] == '[' || str[i] == ']')
                        stack.Push(str[i]);
                }

                if (stack.Peek() == '(' || stack.Peek() == '{' || stack.Peek() == '[')
                {
                    return "Not Balanced";
                }


                int count = stack.Count;
                for (int i = 0; i < count; i++)
                {
                    Flag = CheckFullBrackets(stack);
                    if (stack.Count == 0 && Flag == true)
                    {
                        return "Balanced";
                    }
                    else if (stack.Count != 0 && Flag == true)
                    {
                        
                    }
                    else
                    {
                        return "Unbalanced";
                    }
                }
            }
            return "Not Balanced";
        }

        private static bool CheckFullBrackets(Stack<char> stack)
        {
            bool flag = false;
            char PreviosChar = '0';
            if (stack.Count != 0)
            {
                PreviosChar = stack.Pop();
                if (stack.Count != 0)
                {
                    if ((string.Concat(stack.Peek(), PreviosChar) == "()")
                   || (string.Concat(stack.Peek(), PreviosChar) == "{}"
                   || (string.Concat(stack.Peek(), PreviosChar) == "[]")))
                    {
                        stack.Pop();
                        return true;
                    }

                    else if (stack.Count != 0)
                    {
                        flag = CheckFullBrackets(stack); // Recursion ( sorry for stupid the answer :) )
                        if (stack.Count != 0)
                        {
                            if ((flag == true) && ((string.Concat(stack.Peek(), PreviosChar) == "()")
                                || (string.Concat(stack.Peek(), PreviosChar) == "{}")
                                || (string.Concat(stack.Peek(), PreviosChar) == "[]")))
                            {
                                stack.Pop();
                                return true;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }

                    return false;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            } 
        }
    }

    /* Sorry for the stupid Answer */
    #endregion
}







