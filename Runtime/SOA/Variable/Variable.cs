
using System;
using UnityEngine;

namespace Pickgliss.SOA
{
    public abstract class Variable<T> : ScriptableObject where T : unmanaged
    {
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public T Value;

        public void SetValue(T value)
        {
            Value = value;
        }

        public void SetValue(Variable<T> value)
        {
            SetValue(value.Value);
        }
    }
}