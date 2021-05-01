using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pickgliss.SOA
{
    public class GameEventGeneric<T> : ScriptableObject
    {
        private readonly HashSet<Action<T>> _actions = new HashSet<Action<T>>();
       // rest almost same as GameEvent
  }
}