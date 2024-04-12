using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MyStack<T>
{
    private List<T> stack = new List<T>();

    public int Count()
    {
        return stack.Count;
    }

    public T Pop()
    {
        if (stack.Count == 0)
        {
            throw new InvalidOperationException("Cannot pop from an empty stack.");
        }

        T item = stack[stack.Count - 1];

        stack.RemoveAt(stack.Count - 1);
        return item;
    }

    public void Push(T item)
    {
        stack.Add(item);
    }
}





