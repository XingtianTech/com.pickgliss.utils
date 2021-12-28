using UnityEngine;

namespace Pickgliss.SOA.Random
{
    [CreateAssetMenu(fileName = "SubSeed",menuName = "Random/SubSeed")]
    public class SubSeed : ScriptableObject
    {
        public Seed global;
        public uint value;
        public Unity.Mathematics.Random  rnd1;
        public Unity.Mathematics.Random  rnd2;
        public Unity.Mathematics.Random  rnd3;
        public Unity.Mathematics.Random  rnd4;
        private void OnValidate()
        {
            rnd1 = new Unity.Mathematics.Random(global.Value.x^value);
            rnd2 = new Unity.Mathematics.Random(global.Value.y^value);
            rnd3 = new Unity.Mathematics.Random(global.Value.z^value);
            rnd4 = new Unity.Mathematics.Random(global.Value.w^value);
        }
    }
}