using ArrayStack = StackGFG.ImplementStackWithArray.Stack;
using LinkedListStack = StackGFG.StackAsLinkedList.Stack;
//LIFO : Last in first out

LinkedListStack linkedListStack = new();
linkedListStack.Push(11);
linkedListStack.Push(12);
linkedListStack.Push(13);
linkedListStack.Push(14);
linkedListStack.Push(15);
linkedListStack.Pop();
linkedListStack.Pop();
linkedListStack.Pop();
linkedListStack.PrintAll();

ArrayStack stack = new(5);
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);
stack.Push(6);
Console.WriteLine(stack.Peek());
stack.Pop();
stack.PrintElements();


Stack<int> intStack = new Stack<int>();
intStack.Push(0);
intStack.Push(1);
intStack.Push(2);
intStack.Push(4);
intStack.Push(5);

Console.WriteLine("Stack");
int count = intStack.Count;
for (int i = 0; i < count; i++)
{
    Console.Write($"{intStack.Pop()} ");
}


Queue<int> intQueue = new Queue<int>();
intQueue.Enqueue(0);
intQueue.Enqueue(1);
intQueue.Enqueue(2);
count = intQueue.Count;
Console.WriteLine($"{Environment.NewLine}Queue");
for (int i = 0; i < count; i++)
{
    Console.Write($"{intQueue.Dequeue()} ");
}
