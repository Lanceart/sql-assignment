public class MyList<T>
{
    private T[] items;
    private int count;

    public MyList()
    {
        items = new T[100];
        count = 0;
    }

    public void Add(T element)
    {
        items[count++] = element;
    }

    public T Remove(int index)
    {
        if (index < 0 || index >= count)
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

        T item = items[index];
        for (int i = index; i < count - 1; i++)
        {
            items[i] = items[i + 1];
        }
        count--;
        return item;
    }

    public bool Contains(T element)
    {
        return items.Contains(element);
    }

    public void Clear()
    {
        count = 0;
    }

    public void InsertAt(T element, int index)
    {
        if (index < 0 || index >= count)
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        for (int i = index; i < count; i++)
        {
            items[i + 1] = items[i];
        }

        items[index] = element;

        count++;
    }

    public void DeleteAt(int index)
    {
        if (index < 0 || index >= count)
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");


        for (int i = index; i < count - 1; i++)
        {
            items[i] = items[i + 1];
        }
        count--;
    }

    public T Find(int index)
    {
        if (index < 0 || index >= count)
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

        return items[index];
    }

}
