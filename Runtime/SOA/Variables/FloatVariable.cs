
using UnityEngine;

namespace Pickgliss.SOA
{
    [CreateAssetMenu(fileName = FloatVariable.Name,menuName = SOASetting.SOA_Value + FloatVariable.Name,order = 0)]
    public class FloatVariable : NumericVariable<float>
    {
        public const string Name = "FloatValue";
    }
}