using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Pickgliss.Collections
{
    public class MultiDictionary<TKey, TValue>
    {
        private readonly Dictionary<TKey, List<TValue>> _Data = new Dictionary<TKey, List<TValue>>();

        public Dictionary<TKey, List<TValue>>.ValueCollection Values => _Data.Values;
        public Dictionary<TKey, List<TValue>>.KeyCollection Keys => _Data.Keys;
        public void Add(TKey key, TValue value) { this[key].Add(value); }
        public bool Remove(TKey key, TValue value) { return this[key].Remove(value); }
        public void Clear() { _Data.Clear(); }
        public bool ContainsKey(TKey key) { return _Data.ContainsKey(key); }
        public bool TryGetValue(TKey key, out List<TValue> value) { return _Data.TryGetValue(key, out value); }

        private struct Entry : IEnumerable<TValue>
        {
            private readonly MultiDictionary<TKey, TValue> _Dictionary;
            private TKey Key { get; }

            internal void Add(TValue value)
            {
                if (!_Dictionary._Data.TryGetValue(Key, out var list))
                    list = new List<TValue>();
                list.Add(value);
                _Dictionary._Data[Key] = list;
            }

            internal bool Remove(TValue value)
            {
                if (!_Dictionary._Data.TryGetValue(Key, out var list))
                    return false;
                var result = list.Remove(value);
                if (list.Count == 0)
                    _Dictionary._Data.Remove(Key);
                return result;
            }

            internal Entry(MultiDictionary<TKey, TValue> dictionary, TKey key)
            {
                _Dictionary = dictionary;
                Key        = key;
            }

            public IEnumerator<TValue> GetEnumerator()
            {
                return !_Dictionary._Data.TryGetValue(Key, out var list) ? Enumerable.Empty<TValue>().GetEnumerator() : list.GetEnumerator();
            }
            IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
        }

        private Entry this[TKey key] => new Entry(this, key);
    }
}