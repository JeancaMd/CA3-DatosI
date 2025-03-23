public class Program
{
    public static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        Console.WriteLine(stack.Pop()); // Output: 2
        Console.WriteLine(stack.Peek()); // Output: 1
    }
}
public class Stack<T>
{
    private T[] _elements;
    private int _size;
    private const int DefaultCapacity = 4;

    public Stack()
    {
        _elements = new T[DefaultCapacity];
        _size = 0;
    }

    public void Push(T item)
    {
        if (_size == _elements.Length)
        {
            Array.Resize(ref _elements, _size * 2);
        }
        _elements[_size++] = item;
    }

    public T Pop()
    {
        if (_size == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        T item = _elements[--_size];
        _elements[_size] = default!; 
        return item;
    }

    public T Peek()
    {
        if (_size == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        return _elements[_size - 1];
    }

    public bool IsEmpty()
    {
        return _size == 0;
    }

    public int Count
    {
        get { return _size; }
    }
}
