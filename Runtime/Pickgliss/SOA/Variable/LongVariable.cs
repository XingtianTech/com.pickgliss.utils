
using UnityEngine;

namespace Pickgliss.SOA.Variable
{
    [CreateAssetMenu(fileName = LongVariable.Name,menuName = SOASetting.SOA_Value + LongVariable.Name,order = 0)]
    public class LongVariable : Variable<long>
    {
        public const string Name = "Long";
    }
}