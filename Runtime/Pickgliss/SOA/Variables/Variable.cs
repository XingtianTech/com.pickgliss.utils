using System;
using UnityEngine;
namespace Pickgliss.SOA.Variables
{
    public class Variable<T> : ScriptableObject where T: notnull
    {
        
#if UNITY_EDITOR
        [Multiline]
        public string developerDescription = "";
#endif
        public T value;

        public void SetValue(T v)
        {
            value = v;
        }

        public void SetValue(Variable<T> v)
        {
            value = v.value;
        }

        public void ApplyChange(T amount)
        {
            dynamic dValue = value;
            dynamic aAmount = amount;
            // dynamic result = value + amount;
            value = dValue + aAmount;
        }

        public void ApplyChange(Variable<T> amount)
        {
            dynamic dValue = value;
            dynamic aAmount = amount.value;
            value = dValue + aAmount;
        }
    }
}