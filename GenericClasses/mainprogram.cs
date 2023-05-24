using System;
using task_week_2;

namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList<object> datas = new();
            datas.Adding("Data");
            datas.Adding(45);
            
            Console.WriteLine(datas.Pee);

            Stack<object> stack = new Stack<object>();
            Queue<object> queue = new Queue<object>();
           
        }
    }
    }
}
