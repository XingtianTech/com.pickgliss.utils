using Pickgliss.SOA.Event;
using UnityEngine;

namespace Pickgliss.SOA.Collections
{
    [CreateAssetMenu(fileName = "SelectableGroup",menuName = "Collection/SelectableGroup")]
    public class SelectableGroup : Group
    {
        public GroupItem selected;
        public GameEvent selectChangeEvent;
        public bool Select(GroupItem item)
        {
            // if (!items.Contains(item)) return false;
            if (selected == item) return false;
            selected = item;
            selectChangeEvent.Raise();
            return true;
        }
    }
}