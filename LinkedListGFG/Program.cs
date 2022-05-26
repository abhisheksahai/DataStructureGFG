using LinkedListGFG;

Console.WriteLine("Linked List!");

DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
doublyLinkedList.Push(10);
doublyLinkedList.Push(20);
doublyLinkedList.Append(50);
doublyLinkedList.InsertAfter(doublyLinkedList.head.Next, 100);
doublyLinkedList.PrintList(doublyLinkedList.head);

//SinglyLinkedList linkedList = new SinglyLinkedList();
//linkedList.Execute();