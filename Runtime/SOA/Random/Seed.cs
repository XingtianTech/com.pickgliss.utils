using UnityEngine;
using Unity.Mathematics;

namespace Pickgliss.SOA
{
    [CreateAssetMenu(fileName = "Seed",menuName = "Random/Seed")]
    public class Seed : ScriptableObject
    {
        [SerializeField]
        private string _seed = "a4a9aff793e557d4790d9a834c6560bc";
        public string seed => _seed;

        private uint4 _value = default;
        public uint4 Value => _value;
        private void OnEnable()
        {
            Update();
        }

        private void OnValidate()
        {
            Update();
        }
        private void Update()
        {
            _value = SeedHelper.HashStringToUint4(_seed);
        }
    }
}