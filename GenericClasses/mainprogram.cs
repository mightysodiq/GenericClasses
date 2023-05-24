using System;


namespace GenericClasses
{
    class rogram
    {
        static void Main(string[] args)
        {
            SinglyLinkedList <object> data = new();
            data.Adding("Data");
            data.Adding(45);
            
            

            Stacking<string> stack = new Stacking<string>();
            Stacking<int> stack2 = new Stacking<int>();
            Queueing<int> queue = new Queueing<int>();

            Console.WriteLine(stack.Peek());

        }
    }
 
}
