
using System;
using UnityEngine;

namespace Pickgliss.SOA
{
    public abstract class NumericVariable<T> : ScriptableObject where T : unmanaged
    {
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public T Variable;

        public void SetValue(T value)
        {
            Variable = value;
        }

        public void SetValue(NumericVariable<T> value)
        {
            Variable = value.Variable;
        }
    }
}