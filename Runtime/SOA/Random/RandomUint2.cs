using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = Unity.Mathematics.Random;

namespace Pickgliss.SOA
{
    [CreateAssetMenu(fileName = RandomUint2.Name,menuName = SOASetting.SOA_Random + RandomUint2.Name,order = 0)]
    public class RandomUint2 : ScriptableObject
    {
        public const string Name = "RandomUint2";
        public UInt4Variable seed;
        public IntVariable count;
        public Int2Variable min;
        public Int2Variable max;
        private List<int2> _result;
        public List<int2> Value => _result;

        private void OnEnable()
        {
            _result = new List<int2>();
            OnValidate();
        }

        private void OnValidate()
        {
            var random = new Random(seed.Value.x);
            _result.Clear();
            for (int i = 0; i < count.Value; i++)
            {
                
            }
        }
        
    }
}