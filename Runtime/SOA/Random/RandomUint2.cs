using Unity.Mathematics;
using UnityEngine;

namespace Pickgliss.SOA
{
    [CreateAssetMenu(fileName = RandomUint2.Name,menuName = SOASetting.SOA_Random + RandomUint2.Name,order = 0)]
    public class RandomUint2 : ScriptableObject
    {
        public const string Name = "RandomUint2";
        public Int4Variable seed;
        public IntVariable count;
        public Int2Variable min;
        public Int2Variable max;
        
        
    }
}