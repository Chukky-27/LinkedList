namespace Week_1Tsk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.Add(10);
            linkedList.Add(25);
            linkedList.Add(30);
            linkedList.Add(40);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  |---------------------|");
            Console.WriteLine("  | SINGLY LINKED LIST  |");
            Console.WriteLine("  |---------------------|");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(" List Size: " + linkedList.Add(20));
            Console.WriteLine(" List Size: " + linkedList.Add(50));
            Console.WriteLine();

            Console.WriteLine(" Removed: " + linkedList.Remove(60));
            Console.WriteLine(" Removed: " + linkedList.Remove(60));
            Console.WriteLine();

            Console.WriteLine(" Check: " + linkedList.Check(25));
            Console.WriteLine(" Check: " + linkedList.Check(30));
            Console.WriteLine();

            Console.WriteLine(" Index: " + linkedList.Index(20));
            Console.WriteLine(" Index: " + linkedList.Index(90));
            Console.WriteLine();
            Console.WriteLine();

            Stack<int>stack = new Stack<int>();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("  |-------------|");
            Console.WriteLine("  |    STACK    |");
            Console.WriteLine("  |-------------|");
            Console.WriteLine();
            Console.ResetColor();

            Console.WriteLine("  Stack is empty = " + stack.IsEmpty());

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);
            stack.Push(60);

            Console.WriteLine("  Stack is empty = " + stack.IsEmpty());
            Console.WriteLine();

            Console.WriteLine("  Returned last item added to the stack which is = " + stack.Peek());
            Console.WriteLine();

            Console.WriteLine("  Removed last item added to the stack which is = " + stack.Pop());
            Console.WriteLine();

            Console.WriteLine("  Returned last item added to the stack which is = " + stack.Size());
            Console.WriteLine();

            Queue<int> queue = new Queue<int>();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("  |------------|");
            Console.WriteLine("  |   QUEUE    |");
            Console.WriteLine("  |------------|");
            Console.WriteLine();
            Console.ResetColor();

            Console.WriteLine("  Queue is empty = " + queue.IsEmpty());

            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Enqueue(15);
            queue.Enqueue(20);
            queue.Enqueue(25);
            queue.Enqueue(30);
            
            Console.WriteLine("  Queue is empty = " + queue.IsEmpty());
            Console.WriteLine();

            Console.WriteLine("  Returned last item added to the queue which is = " + queue.Size());
            Console.WriteLine();

            Console.WriteLine("  Removed last item added to the queue which is = " + queue.Dequeue());
            Console.WriteLine();

            Console.WriteLine("  Returned last item added to the queue which is = " + queue.Size());
            




        }
    }
}