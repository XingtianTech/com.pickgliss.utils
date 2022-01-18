using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pickgliss.SOA.Collections
{
    public  class Collection<T> : ScriptableObject ,IList<T>
    {
        public List<T> items;
        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Clear()
        {
            items.Clear();
        }

        public bool Contains(T item)
        {
            return items.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            items.CopyTo(array,arrayIndex);
        }

        public bool Remove(T item)
        {
            return items.Remove(item);
        }

        public int Count => items.Count;
        public bool IsReadOnly => false;
        public int IndexOf(T item)
        {
            return items.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            items.Insert(index,item);
        }

        public void RemoveAt(int index)
        {
            items.RemoveAt(index);
        }

        public T this[int index]
        {
            get => items[index];
            set => items[index] = value;
        }
    }
}