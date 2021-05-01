
using UnityEngine;

namespace Pickgliss.SOA
{
    [CreateAssetMenu(fileName = FloatVariable.Name,menuName = SOASetting.SOA_Value + FloatVariable.Name,order = 0)]
    public class FloatVariable : ScriptableObject
    {
        public const string Name = "FloatValue";
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public float Value;

        public void SetValue(float value)
        {
            Value = value;
        }

        public void SetValue(FloatVariable value)
        {
            Value = value.Value;
        }

        public void ApplyChange(float amount)
        {
            Value += amount;
        }

        public void ApplyChange(FloatVariable amount)
        {
            Value += amount.Value;
        }
    }
}