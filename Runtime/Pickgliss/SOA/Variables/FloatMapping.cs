using System.Collections.Generic;
using System;

namespace Pickgliss.SOA.Variables
{
    public class FloatMapping : UnityEngine.MonoBehaviour
    {
        public List<FloatMappingEntry> variables;
        void OnEnable()
        {
            foreach (var entry in variables)
            {
                entry.variable.SetValue(entry.value);
            }
        }
    }


    [Serializable]
    public class FloatMappingEntry
    {
        public Variable<float> variable;
        public float value;
    }
}