// using System.Collections.Generic;

using System.Collections.Generic;
using UnityEngine;

namespace Pickgliss.Collections
{
    [CreateAssetMenu(fileName = "DropsPackage",menuName = "Collection/DropsPackage")]
    public class DropsPackage<T> : ScriptableObject
    {
        public List<DropItem<T>> items;
    }
}