using System;
using UnityEngine;
using UnityEngine.Events;

namespace Pickgliss.SOA
{
    public class TestAuthoring : MonoBehaviour
    {
        public GameEvent1 action;
        public GameEventParameters<NumericReference<int>> ac2;
        public void Testcall(NumericReference<int> input)
        {
            // return "aaa";
        }
    }

    [Serializable] public class GameEvent1 : UnityEvent<string> { }
    [Serializable] public class GameEventParameters<T> : UnityEvent<T> { }
}