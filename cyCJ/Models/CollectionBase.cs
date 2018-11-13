using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyCJ.Models
{
    public abstract class CollectionBase<T>
    {
        protected List<T> _items;

        public CollectionBase()
        {
            _items = new List<T>();
        }
        public abstract void ReadDB();

        public int Add(T item)
        {
            if (_items.Contains(item))
            {
                return -1;
            }
            var conn = DBContext.DBConnection;
            var id = conn.Insert(item);
            if (id < 0)
                return -1;
            _items.Add(item);
            return id;
        }
        public void Update(int index, T item)
        {
            var conn = DBContext.DBConnection;
            conn.Update(_items[index]);
        }
        public void Delete(int index)
        {
            T item = _items[index];

            var conn = DBContext.DBConnection;
            conn.Delete(item);
            _items.RemoveAt(index);
        }
        public void Clear()
        {
            var conn = DBContext.DBConnection;
            conn.DeleteAll<Prize>();
            _items.Clear();
        }
    }
}
