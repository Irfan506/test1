using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    public class towerofhanoi
    {
        public Stack<char> stk = new Stack<char>();
        public void add(char ch)
        {
            stk.Push(ch);
        }
        public void print()
        {
            while (stk.Count > 0)
                Console.Write(stk.Pop());
        }
        public int check()
        {
            Stack<char> stk1 = new Stack<char>();
            stk1 = stk;
            if (stk.Count != 3)
                return 0;
            char ch1 = stk1.Pop();
            char ch2 = stk1.Pop();
            char ch3 = stk1.Pop();
            if (ch1.Equals(ch2) && ch1.Equals(ch3))
            {
                
                return 1;
            }
                      
            else
                return 0;
        }
    }
}
