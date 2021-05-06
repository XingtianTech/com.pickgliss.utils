// using System;
// using System.Collections.Generic;
// using UnityEngine;

// namespace Pickgliss.SOA
// {
//     public class GameEventGeneric<T> : ScriptableObject
//     {
//         private readonly HashSet<Action<T>> _actions = new HashSet<Action<T>>();
//        // rest almost same as GameEvent
//   }
// }

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pickgliss.SOA
{
    public class GameEvent1<T> : ScriptableObject
    {
        private readonly HashSet<Action<T>> actions = new HashSet<Action<T>>();
        public void Raise(T parameter)
        {
            // base.Raise();
            foreach (var item in actions)
            {
                item(parameter);
            }
        }

        // public void RegisterListener(GameEventListener1 listener)
        // {
        //     if (!actions.Contains(listener))
        //         actions.Add(listener);
        // }

    }
}