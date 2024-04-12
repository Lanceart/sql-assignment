using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GenericRepository<T> : IRepository<T> where T : class
{
    private List<T> _items = new List<T>();

    public void Add(T item)
    {
        if (item == null)
            throw new ArgumentNullException(nameof(item));

        _items.Add(item);
    }

    public void Remove(T item)
    {
        if (item == null)
            throw new ArgumentNullException(nameof(item));

        T existing = _items.FirstOrDefault(i => i.Id == item.Id);
        if (existing != null)
        {
            _items.Remove(existing);
        }
    }

    public void Save()
    {
        return;
    }

    public IEnumerable<T> GetAll()
    {
        return _items.ToList();
    }

    public T GetById(int id)
    {
        return _items.FirstOrDefault(i => i.Id == id);
    }
}
