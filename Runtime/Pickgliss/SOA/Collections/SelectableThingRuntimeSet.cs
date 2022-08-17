// using Pickgliss.SOA.Events;
// using UnityEngine;

// namespace Pickgliss.SOA.Collections
// {
//     [CreateAssetMenu(fileName = "SelectableGroup",menuName = "Collection/SelectableGroup")]
//     public class SelectableThingRuntimeSet : ThingRuntimeSet
//     {
//         public Thing selected;
//         public GameEvent selectChangeEvent;
//         public bool Select(Thing item)
//         {
//             // if (!items.Contains(item)) return false;
//             if (selected == item) return false;
//             selected = item;
//             selectChangeEvent.Raise();
//             return true;
//         }
//     }
// }