namespace StackGFG.StackAsLinkedList
{
    public class Stack
    {
        public class StackNode
        {
            public int data;
            public StackNode next;
            public StackNode(int data)
            {
                this.data = data;
            }
        }

        public StackNode? root;

        public void Push(int data)
        {
            StackNode node = new StackNode(data);
            if (root == null)
            {
                root = node;
            }
            else
            {
                StackNode tempNode = root;
                root = node;
                root.next = tempNode;
            }
            Console.WriteLine($"Pushed {data} into the stack");
        }

        public int Pop()
        {
            int retValue = int.MinValue;
            if (root == null)
            {
                Console.WriteLine("Stack underflow");
                return retValue;
            }
            retValue = root.data;
            Console.WriteLine($"Popped {root.data} from the stack");
            if (root.next == null)
            {
                root = null;
            }
            else
            {
                root = root.next;
            }
            return retValue;
        }

        public int Peep()
        {
            int retValue = int.MinValue;
            if (root == null)
            {
                Console.WriteLine("Stack underflow");
                return retValue;
            }
            retValue=root.data;
            Console.WriteLine($"Peep {root.data} from the stack");
            return retValue;
        }

        public void PrintAll()
        {
            StackNode stackNode = root;
            while(stackNode != null)
            {
                Console.Write($"{stackNode.data} ");
                stackNode=stackNode.next;
            }
        }
    }
}
