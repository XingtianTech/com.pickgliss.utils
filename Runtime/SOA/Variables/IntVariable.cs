
using UnityEngine;

namespace Pickgliss.SOA
{
    [CreateAssetMenu(fileName = IntVariable.Name,menuName = SOASetting.SOA_Value + IntVariable.Name,order = 0)]
    public class IntVariable : NumericVariable<int>
    {
        public const string Name = "IntValue";
    }
}