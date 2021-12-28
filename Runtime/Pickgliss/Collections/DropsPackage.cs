// using System.Collections.Generic;

using System.Collections.Generic;
using UnityEngine;

namespace Pickgliss.Collections
{
    [CreateAssetMenu(fileName = "DropsPackage",menuName = "Collection/DropsPackage")]
    public class DropsPackage<T> : ScriptableObject
    {
        public List<DropItem<T>> items;
        private float _totalChance;

        public void Update()
        {
            _totalChance = 0;
            foreach (var item in items)
            {
                _totalChance += item.chance.Value;
            }
        }

        private void OnValidate()
        {
            Update();
        }
        
    }
}