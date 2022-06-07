namespace StackGFG.ImplementStackWithArray
{
    public class Stack
    {
        private int _top;
        private int _max;
        private int[] _elements;

        public Stack(int size)
        {
            _max = size;
            _top = -1;
            _elements = new int[size];
        }

        public void Push(int element)
        {
            if (_top == _max - 1)
            {
                Console.WriteLine("Stack overflow");
                return;
            }
            _elements[++_top] = element;
        }

        public int Pop()
        {
            if (_top == -1)
            {
                Console.WriteLine("Stack underflow");
                return -1;
            }
            Console.WriteLine($"Popped {_elements[_top]} from stack");
            return _elements[_top--];
        }

        public int Peek()
        {
            if (_top == -1)
            {
                Console.WriteLine("Stack underflow");
            }
            return _elements[_top];
        }

        public void PrintElements()
        {
            if( _top == -1)
            {
                Console.WriteLine("Stack underflow");
            }
            for (int i = 0; i <= _top; i++)
            {
                Console.Write($"{_elements[i]} ");
            }
        }
    }
}
