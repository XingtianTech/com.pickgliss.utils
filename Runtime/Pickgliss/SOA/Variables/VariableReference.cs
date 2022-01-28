using System;

namespace Pickgliss.SOA.Variables
{
    [Serializable]
    public class VariableReference<T>
    {
        public bool useConstant = true;
        public T constantValue;
        public Variable<T> variable;

        public VariableReference()
        { }

        public VariableReference(T value)
        {
            useConstant = true;
            constantValue = value;
        }

        public T Value => useConstant ? constantValue : variable.value;

        public static implicit operator T(VariableReference<T> reference)
        {
            return reference.Value;
        }
    }
}