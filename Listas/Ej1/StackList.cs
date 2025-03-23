public class Pila<T> {
    public List<T> lista;

    public Pila()
    {
        lista = new List<T>();
    }

    public void Push(T value)
    {
        lista.Add(value);
    }

    public T Pop()
    {
        if(lista.Count == 0)
        {
            throw new InvalidOperationException("La pila esta vacia");
        }
        else
        {
            T value = lista[lista.Count - 1];
            lista.RemoveAt(lista.Count - 1);
            return value;
        }
    }

    public T Top()
    {
        if (lista.Count == 0) throw new InvalidOperationException("La pila esta vacia");
        return lista[lista.Count - 1];
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
