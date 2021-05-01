
using UnityEngine;

namespace Pickgliss.SOA
{
    [CreateAssetMenu(fileName = LongVariable.Name,menuName = SOASetting.SOA_Value + LongVariable.Name,order = 0)]
    public class LongVariable : NumericVariable<long>
    {
        public const string Name = "Long";
    }
}