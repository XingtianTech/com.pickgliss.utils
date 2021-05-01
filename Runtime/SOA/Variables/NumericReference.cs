using System;
using UnityEngine;
namespace Pickgliss.SOA
{
    [Serializable]
    public class NumericReference<T> where T : unmanaged
    {
        public bool UseConstant = true;
        public T ConstantValue;
        public NumericVariable<T> Variable;

        public NumericReference()
        { }

        public NumericReference(T value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public T Value
        {
            get { return UseConstant ? ConstantValue : Variable.Variable; }
        }

        public static implicit operator T(NumericReference<T> reference)
        {
            return reference.Value;
        }
    }
}