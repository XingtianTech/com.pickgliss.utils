using UnityEngine;

namespace Pickgliss.SOA.Variable
{
    [CreateAssetMenu(fileName = "IntVariable",menuName = "Variable/IntVariable")]
    public class IntVariable : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline]
        public string developerDescription = "";
#endif
        public int value;

        public void SetValue(int v)
        {
            value = v;
        }

        public void SetValue(IntVariable v)
        {
            value = v.value;
        }

        public void ApplyChange(int amount)
        {
            value += amount;
        }

        public void ApplyChange(IntVariable amount)
        {
            value += amount.value;
        }
    }
}