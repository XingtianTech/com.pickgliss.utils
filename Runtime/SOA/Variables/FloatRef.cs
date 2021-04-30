using System;
using UnityEngine;
namespace Pickgliss.SOA
{
    [Serializable]
    public class FloatRef
    {
        public bool UseConstant = true;
        public float ConstantValue;
        public FloatValue Variable;

        public FloatRef()
        { }

        public FloatRef(float value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public float Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator float(FloatRef reference)
        {
            return reference.Value;
        }
    }
}