using UnityEngine;
using UnityEngine.Events;

namespace Pickgliss.SOA
{
    public class VariableModifier<T> where T : unmanaged
    {
        public UnityEvent onChange;
        public Variable<T> Variable;
        private void OnValidate()
        {
            onChange.Invoke();
        }

        public VariableModifier()
        { }

        public VariableModifier(UnityEvent change)
        {
            onChange = change;
        }

        public T Value
        {
            get { return Variable.Value; }
        }

        public static implicit operator T(VariableModifier<T> reference)
        {
            return reference.Value;
        }
    }
}