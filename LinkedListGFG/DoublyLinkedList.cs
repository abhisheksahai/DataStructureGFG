namespace LinkedListGFG
{
    public class Node
    {
        public int Data;
        public Node Previous;
        public Node Next;
        public Node(int data)
        {
            Data = data;
        }
    }

    public class DoublyLinkedList
    {
        public Node head;

        /// <summary>
        /// Add a node at the font of the DoublyLinkedList
        /// </summary>
        /// <param name="newData"></param>
        public void Push(int newData)
        {
            Node newNode = new Node(newData);
            newNode.Next = head;
            newNode.Previous = null;

            if (head != null)
            {
                head.Previous = newNode;
            }
            head = newNode;
        }

        /// <summary>
        /// InsertAfter
        /// </summary>
        /// <param name="prevNode"></param>
        /// <param name="data"></param>
        public void InsertAfter(Node prevNode, int data)
        {
            if (prevNode == null)
            {
                Console.WriteLine($"{nameof(prevNode)} can not be null");
                return;
            }

            Node newNode = new Node(data)
            {
                Next = prevNode.Next
            };
            if (newNode.Next != null)
            {
                newNode.Next.Previous = newNode;
            }
            newNode.Previous = prevNode;
            prevNode.Next = newNode;
        }

        /// <summary>
        /// Append node at the last
        /// </summary>
        /// <param name="data"></param>
        public void Append(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = null;

            if (head == null)
            {
                newNode.Previous = null;
                head = newNode;
                return;
            }

            Node last = head;
            while (last.Next != null)
            {
                last = last.Next;
            }

            newNode.Previous = last;
            last.Next = newNode;

        }

        public void PrintList(Node node)
        {
            if (node == null)
            {
                Console.WriteLine($"{nameof(node)} can not be null");
                return;
            }
            Console.WriteLine("Traversal in forward direction");
            Node lastNode = node;
            while (lastNode.Next != null)
            {
                Console.Write($"{lastNode.Data} ");
                lastNode = lastNode.Next;
            }
            Console.Write($"{lastNode.Data} ");
            Console.WriteLine($"{Environment.NewLine}Traversal in backward direction");
            while (lastNode.Previous != null)
            {
                Console.Write($"{lastNode.Data} ");
                lastNode = lastNode.Previous;
            }
            Console.Write($"{node.Data}");
        }
    }
}