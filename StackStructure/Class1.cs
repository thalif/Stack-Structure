using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackStructure
{
    public class Stack
    {
        public static int Capacity = 0;
        public int[] Data;
        public int Count;

        bool _isEmpty;

        public bool IsEmpty
        {
            get
            {
                if (Count == 0)
                    return true;
                else
                    return false;
            }
        }
        
        public void Push(int item)
        {
            if(Count >= Capacity)
                throw new StackOverflowException("Your stack is full");
            else
                Data[Count++] = item;
        }
        public void Pop()
        {
            if (Count == 0)
                throw new InvalidOperationException("Your Stack is empty, No elements to pop");
            else
                Data[--Count] = 0;
        }

        public void Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException("Your stack is Empty, no elements to show");
            else
                Console.WriteLine(Data[Count - 1]);
        }

        public void Print()
        {
            if (Count == 0)
                throw new InvalidOperationException("Your Stak has no elements to print");
            else
            {
                for(int i = Count - 1; i >= 0; i--)
                    Console.Write(Data[i]);
            }
        }

        public Stack(int size)
        {
            Capacity = size;
            Data = new int[Capacity];
            Count = 0;
        }
    }
}
