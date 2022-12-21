using System;
using UnityEngine;
namespace Pickgliss.SOA.Variables
{
    public abstract class RangeVariable<T> : VariableBase
    {
        public Variable<T> min;
        public Variable<T> max;
        public abstract T RandomOne();
    }
}