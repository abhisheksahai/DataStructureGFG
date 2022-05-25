using System.Collections.Generic;

namespace LinkedListGFG
{
    public class Node
    {
        int Data;
        public Node Previous;
        public Node Next;
        public Node(int d)
        {
            Data = d;
        }
    }

    public class DoublyLinkedList
    {
        Node head;

        /// <summary>
        /// Add a node at the font of the DoublyLinkedList
        /// </summary>
        /// <param name="newData"></param>
        public void Push(int newData)
        {
            Node newNode = new Node(newData);
            newNode.Next = head;
            newNode.Previous = null;

            if(head != null)
            {
                head.Previous = newNode;
            }
            head = newNode;
        }
    }
}