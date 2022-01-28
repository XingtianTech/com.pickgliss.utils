using System;
using System.Linq;
using System.Collections.Generic;
using Pickgliss.SOA.Variables;
using UnityEngine;

namespace Pickgliss.LootTables
{
    
    [CreateAssetMenu(fileName = "LootTable", menuName = "Collection/Loot Table")]
    public class LootTable<T> : ScriptableObject
    {
        [SerializeField] protected List<RewardItem<T>> items;

        protected float TotalWeight;
        protected virtual void OnValidate()
        {
            TotalWeight = items.Sum(item => item.weight);
        }

        public T GetRandomItem()
        {
            var diceRoll = UnityEngine.Random.Range(0f, TotalWeight);
            foreach (var item in items)
            {
                if (item.weight >= diceRoll)
                {
                    return item.item;
                }

                diceRoll -= item.weight;
            }
    
            throw new Exception("Reward generation failed!");
        }
    }
    [Serializable]
    public class RewardItem<T>
    {
        public T item;
        public VariableReference<float> weight;
    }

}