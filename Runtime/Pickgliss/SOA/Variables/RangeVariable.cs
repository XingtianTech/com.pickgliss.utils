using System;
using UnityEngine;
namespace Pickgliss.SOA.Variables
{
    public abstract class RangeVariable<T> : VariableBase
    {
        public VariableReference<T> min;
        public VariableReference<T> max;
        public abstract T RandomOne();
    }
}