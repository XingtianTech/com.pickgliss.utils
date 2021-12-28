
using UnityEngine;

namespace Pickgliss.SOA.Variable
{
    [CreateAssetMenu(fileName = IntVariable.Name,menuName = SOASetting.SOA_Value + IntVariable.Name,order = 0)]
    public class IntVariable : Variable<int>
    {
        public const string Name = "Int";
    }
}