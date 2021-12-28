using UnityEngine;

namespace Pickgliss.SOA.Variable
{
    [CreateAssetMenu(fileName = BoolVariable.Name,menuName = SOASetting.SOA_Value + BoolVariable.Name,order = 0)]
    public class BoolVariable : Variable<bool>
    {
        public const string Name = "Bool";
    }
}