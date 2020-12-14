using System;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            towerofhanoi ob1 = new towerofhanoi();
            towerofhanoi ob2 = new towerofhanoi();
            towerofhanoi ob3 = new towerofhanoi();
            for(int i=0;i<3;i++)
            {
                var t = (Console.ReadLine()).Split(' ');
                ob1.add(Convert.ToChar(t[0]));
                ob2.add(Convert.ToChar(t[1]));
                ob3.add(Convert.ToChar(t[2]));
            }
            while(true)
            {
                if (ob1.check() == 1 && ob2.check() == 1)
                    break;
                else
                {
                    char po;
                    var te = (Console.ReadLine()).Split(' ');
                    int a = int.Parse(te[0]);
                    int b = int.Parse(te[1]);
                    if (a == 1)
                    {
                        if (ob1.stk.Count > 0)
                            po = ob1.stk.Pop();
                    }
                    else
                        if (a == 2)
                    {
                        if (ob2.stk.Count > 0)
                            po = ob2.stk.Pop();
                    }
                        
                    else
                    {
                        if (ob2.stk.Count > 0)
                            po = ob3.stk.Pop();
                    }
                        
                    if (b == 1)
                        ob1.stk.Push(po);
                    else
                        if (b == 2)
                        ob2.stk.Push(po);
                    else
                        ob2.stk.Push(po);

                }
                    
            }
        }
    }
}
