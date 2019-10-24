using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
   public class Stack
    {
        int[] Buffer;
        int Top;

        public Stack(int size)
        {
            Buffer = new int[size];
            Top = -1;
        }
       public void Push(int a)
        {
            Buffer[Top + 1] = a;
            Top++;
        }
        public int Pop()
       {
           int value = Buffer[Top];
           Top = Top - 1;
           return value;
       }
        public int Peek()
        {
            return Buffer[Top];

        }
        public int Count()
        {
            return Top + 1;
        }
        public void Clear()
        {
            Top = -1;
        }
    }
}
