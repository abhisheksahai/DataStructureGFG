//LIFO : Last in first out
Stack<int> intStack = new Stack<int>();
intStack.Push(0);
intStack.Push(1);
intStack.Push(2);
intStack.Push(4);
intStack.Push(5);

Console.WriteLine("Stack");
int count= intStack.Count;
for (int i = 0; i < count; i++)
{
    Console.Write($"{intStack.Pop()} ");
}


Queue<int> intQueue = new Queue<int>();
intQueue.Enqueue(0);
intQueue.Enqueue(1);
intQueue.Enqueue(2);
count=intQueue.Count;
Console.WriteLine($"{Environment.NewLine}Queue");
for (int i = 0; i < count; i++)
{
    Console.Write($"{intQueue.Dequeue()} ");
}