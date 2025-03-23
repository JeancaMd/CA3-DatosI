public class Queue<T>
{
    private T[] _elements;
    private int _head;
    private int _tail;
    private int _size;
    private const int DefaultCapacity = 4;

    public Queue()
    {
        _elements = new T[DefaultCapacity];
        _head = 0;
        _tail = 0;
        _size = 0;
    }

    public void Enqueue(T item)
    {
        if (_size == _elements.Length)
        {
            int newCapacity = _size * 2;
            T[] newArray = new T[newCapacity];
            Array.Copy(_elements, _head, newArray, 0, _size - _head);
            Array.Copy(_elements, 0, newArray, _size - _head, _tail);
            _elements = newArray;
            _head = 0;
            _tail = _size;
        }
        _elements[_tail] = item;
        _tail = (_tail + 1) % _elements.Length;
        _size++;
    }

    public T Dequeue()
    {
        if (_size == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        T item = _elements[_head];
        _elements[_head] = default(T); // Clear the reference
        _head = (_head + 1) % _elements.Length;
        _size--;
        return item;
    }

    public T Peek()
    {
        if (_size == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        return _elements[_head];
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
