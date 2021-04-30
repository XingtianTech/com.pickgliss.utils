
using UnityEngine;

namespace Pickgliss.SOA
{
    [CreateAssetMenu(fileName = FloatValue.Name,menuName = SOASetting.SOA_Value + FloatValue.Name,order = 0)]
    public class FloatValue : ScriptableObject
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

        public void SetValue(FloatValue value)
        {
            Value = value.Value;
        }

        public void ApplyChange(float amount)
        {
            Value += amount;
        }

        public void ApplyChange(FloatValue amount)
        {
            Value += amount.Value;
        }
    }
}