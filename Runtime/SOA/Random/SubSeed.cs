using UnityEngine;
using Random = Unity.Mathematics.Random;
namespace Pickgliss.SOA
{
    [CreateAssetMenu(fileName = "SubSeed",menuName = "Random/SubSeed")]
    public class SubSeed : ScriptableObject
    {
        public Seed global;
        public uint value;
        public Random  rnd1;
        public Random  rnd2;
        public Random  rnd3;
        public Random  rnd4;
        private void OnValidate()
        {
            rnd1 = new Random(global.Value.x^value);
            rnd2 = new Random(global.Value.y^value);
            rnd3 = new Random(global.Value.z^value);
            rnd4 = new Random(global.Value.w^value);
        }
    }
}