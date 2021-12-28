using Pickgliss.SOA.Variable;
using UnityEngine;

namespace Pickgliss.Collections
{
    public class DropItem<T> : ScriptableObject
    {
        public T item;
        public FloatVariable chance;
    }
}