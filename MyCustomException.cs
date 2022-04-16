using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mystackexception
{
    public class StackException : Exception
    {
        public StackException(String Message) : base(Message)
        {

        }
    }
    internal class MyStackException
    {
        static readonly int MAX1 = 1000;
        int top1;
        int[] arr1 = new int[MAX1];

        public bool IsEmpty()
        {
            return (top1 < 0);
        }
        public MyStackException()
        {
            top1 = 0;
        }
        public void Push(int data)
        {
            if (top1 >= MAX1)
            {
                throw (new StackException("witnessing Stack Overflow scenario"));
            }
            else
            {
                arr1[top1++] = data;
                Console.WriteLine("data will be stored in the array : {0} ", data);
            }
        }
        public void Pop()
        {
            if (top1 < 0)
            {
                throw (new StackException(" Stack Underflow Scenario"));
            }
            else
            {
                int value = arr1[top1--];
                Console.WriteLine("After performing pop operation, The Value will be: {0}", value);
            }
        }
        public void Peek()
        {
            if (top1 < 0)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                Console.WriteLine(arr1[top1]);
            }

        }
        public void PrintStack()
        {
            if (top1 < 0)
            {
                Console.WriteLine("Stack UnderFlow");
            }
            else
            {
                Console.WriteLine("Stack Elements are as follows:");
                for (int i = top1; i > 0; i--)
                {
                    Console.WriteLine(arr1[i]);
                    Console.ReadKey();
                }
            }
        }
        static void Main()
        {
            MyStackException stack1 = new MyStackException();
            Console.WriteLine("Program starts...");
            Console.WriteLine("Please Enter Valid Credentials : ");
            Console.ReadLine();
            Console.WriteLine("< br >");
            Console.WriteLine("Please wait we are checking the status of the Stack, whether it is empty or not!!");
            //Console.ReadLine();
            Console.WriteLine("Evrything is perfect! plase go ahead with pressing ENTER");
            Console.ReadLine();
            stack1.IsEmpty();
            Console.WriteLine("Thanks for your patience! here is the Top Most element");
            stack1.Peek();
            stack1.PrintStack();

            try
            {
                stack1.Push(20);
                stack1.Push(30);
                stack1.Push(65);
                stack1.Push(46);
                stack1.Push(46);
                stack1.Push(86);
            }
            catch (StackException stackException)
            {
                Console.WriteLine(stackException.Message);
            }
            try
            {
                stack1.Pop();
            }
            catch (StackException stackException1)
            {
                Console.WriteLine(stackException1.Message);
            }

            Console.WriteLine("Program ends...");

        }

    }
}