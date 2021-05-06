using System;
using UnityEngine;
using UnityEngine.Events;

namespace Pickgliss.SOA
{
    public class TestAuthoring : MonoBehaviour
    {
        // public UnityEvent action;
        public VariableReference<int> intValue;
        // public NumericUpdater<int> intUpdater;
        // public GameEventParameters<NumericReference<int>> ac2;

        public void writeTest(string input1)
        {

        }
        public void Testcall(VariableReference<int> input)
        {
            // return "aaa";
        }
    }

    [Serializable] public class GameEvent1 : UnityEvent<string> { }
    [Serializable] public class GameEventParameters<T> : UnityEvent<T> { }
}