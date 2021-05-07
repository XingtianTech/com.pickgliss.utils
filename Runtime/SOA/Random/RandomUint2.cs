using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace Pickgliss.SOA
{
    [CreateAssetMenu(fileName = RandomUint2.Name,menuName = SOASetting.SOA_Random + RandomUint2.Name,order = 0)]
    public class RandomUint2 : ScriptableObject
    {
        public const string Name = "RandomUint2";
        public Int4Variable seed;
        public int count;
        public int2 min;
        public int2 max;

        public List<int2> Value;
        
        private void OnEnable()
        {
            Value = new List<int2>();
        }

        private void OnValidate()
        {
            Value.Clear();
            for (int i = 0; i < count; i++)
            {
                
            }
        }
        
    }
}