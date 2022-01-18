using System;

namespace Pickgliss.SOA.Variable
{
    [Serializable]
    public class FloatReference
    {
        public static string UseConstantPropertyString = "useConstant";
        public static string ConstantValuePropertyString = "constantValue";
        public static string VariablePropertyString = "variable";
        public bool useConstant = true;
        public float constantValue;
        public FloatVariable variable;

        public FloatReference()
        { }

        public FloatReference(float value)
        {
            useConstant = true;
            constantValue = value;
        }

        public float Value => useConstant ? constantValue : variable.value;

        public static implicit operator float(FloatReference reference)
        {
            return reference.Value;
        }
    }
}