namespace LinkedListGFG
{
    internal class SinglyLinkedList
    {
        public void Execute()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddFirst("A");
            linkedList.AddFirst("B");
            linkedList.AddLast("C");
            linkedList.AddLast("D");
            linkedList.AddFirst(new LinkedListNode<string>("E"));
            var nodeE = linkedList.Find("B");
            linkedList.AddAfter(nodeE, "F");
            foreach (var item in linkedList)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"{Environment.NewLine}Linked list after deletion of items");
            linkedList.RemoveFirst();
            linkedList.RemoveLast();
            linkedList.Remove(nodeE);
            foreach (var item in linkedList)
            {
                Console.Write($"{item} ");
            }
            if (linkedList.Contains("A"))

            {
                Console.WriteLine($"{Environment.NewLine}A is present in the linked list");
            }
            else
            {
                Console.WriteLine($"{Environment.NewLine}A is not present in the linked list");
            }
        }
    }
}
