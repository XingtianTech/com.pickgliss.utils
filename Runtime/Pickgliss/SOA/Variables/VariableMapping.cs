using System.Collections.Generic;
using System;

namespace Pickgliss.SOA.Variables
{
    public class VariableMapping<T> : UnityEngine.MonoBehaviour
    {
        public List<VariableMappingEntry<T>> variables;
        void OnEnable()
        {
            foreach (var entry in variables)
            {
                entry.variable.SetValue(entry.value);
            }
        }
    }


    [Serializable]
    public class VariableMappingEntry<T>
    {
        public Variable<T> variable;
        public T value;
    }
}