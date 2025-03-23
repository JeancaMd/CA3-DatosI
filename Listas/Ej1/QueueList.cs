public class Queue<T>
{
    public List<T> lista;

    public Queue()
    {
        lista = new List<T>();
    }

    public void Enqueue(T value)
    {
        lista.Add(value);
    }

    public T Dequeue()
    {
        if (lista.Count == 0) throw new InvalidOperationException("La cola esta vacia");
        else
        {
            T value = lista[0];
            lista.RemoveAt(0);
            return value;
        }
    }

    public T Front()
    {
        if (lista.Count == 0) throw new InvalidOperationException("La cola esta vacia");
        return lista[0];
    }

    public void Show()
    {
        Console.WriteLine(string.Join(", ", lista));
    }
    public int Count()
    {
        return lista.Count();
    }
}

